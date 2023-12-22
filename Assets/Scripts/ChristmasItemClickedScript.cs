namespace ARTreasureHunt
{
    using UnityEngine;
    using UnityEngine.UI;
    using EnhancedTouch = UnityEngine.InputSystem.EnhancedTouch;

    public class ChristmasItemClickedScript : MonoBehaviour
    {
        private GameManager gameManager;
        public Image ChristmasItemIcon;
        public GameObject ConfettiAnimationPrefab;

        private void Start()
        {
            gameManager = FindAnyObjectByType<GameManager>();
        }

        private void OnEnable()
        {
            EnhancedTouch.TouchSimulation.Enable();
            EnhancedTouch.EnhancedTouchSupport.Enable();
            EnhancedTouch.Touch.onFingerDown += OnFingerTouch;
        }

        private void OnDisable()
        {
            EnhancedTouch.TouchSimulation.Disable();
            EnhancedTouch.EnhancedTouchSupport.Disable();
            EnhancedTouch.Touch.onFingerDown -= OnFingerTouch;
        }

        private void OnFingerTouch(EnhancedTouch.Finger finger)
        {
            if (finger.index != 0) return;

            Ray ray = Camera.main.ScreenPointToRay(finger.currentTouch.screenPosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100f))
            {
                if (hit.collider.gameObject == gameObject)
                {
                    ChristmasItemFound();
                }
            }
        }

        private void ChristmasItemFound()
        {
            gameManager.HiddenItemFound();
            ChristmasItemIcon.color = new Color(255f, 255f, 255, 255f);
            gameObject.GetComponent<BoxCollider>().enabled = false;
            var animatedConfetti = Instantiate(ConfettiAnimationPrefab, gameObject.transform);
            animatedConfetti.gameObject.SetActive(true);
            Invoke("RemoveChristmasItem", 3);
        }

        private void RemoveChristmasItem()
        {
            Destroy(gameObject);
        }
    }
}
