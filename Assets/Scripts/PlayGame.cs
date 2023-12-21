namespace ARTreasureHunt
{
    using UnityEngine;
    using UnityEngine.SceneManagement;

    public class PlayGame : MonoBehaviour
    {
        public void OnPlayClicked()
        {
            SceneManager.LoadScene("ARTreasureHunt");
        }
    }
}
