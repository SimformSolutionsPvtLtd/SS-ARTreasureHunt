namespace ARTreasureHunt
{
    using UnityEngine;

    public class CloseUIScript : MonoBehaviour
    {
        [SerializeField] GameObject UIElement;

        public void CloseUI()
        {
            UIElement.SetActive(false);
        }
    }
}
