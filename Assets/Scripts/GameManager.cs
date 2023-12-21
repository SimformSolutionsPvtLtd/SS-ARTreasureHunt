namespace ARTreasureHunt
{
    using TMPro;
    using UnityEngine;
    using UnityEngine.SceneManagement;
    using UnityEngine.UI;

    public class GameManager : MonoBehaviour
    {
        public int Score;
        public GameObject CongratsBox;
        public TMP_Text ScoreUIText;
        public TMP_Text CongratsMessage;

        public void ShowCongratsBox()
        {
            CongratsBox.SetActive(true);
        }

        public void HiddenItemFound()
        {
            UpdateScore();
            UpdateScoreUI();
            Invoke("ShowCongratsBox", 1);
        }

        private void UpdateScore()
        {
            Score += 1;
        }

        private void UpdateScoreUI()
        {
            ScoreUIText.text = $"Collected: {Score}/5";

            if (Score == 5)
            {
                CongratsMessage.text = "You have collected all the treasures!";
                var closeButton = CongratsBox.GetComponentInChildren<Button>();
                closeButton.GetComponentInChildren<TMP_Text>().text = "Play Again";
                closeButton.onClick.AddListener(PlayAgain);
            }
        }

        public void PlayAgain()
        {
            SceneManager.LoadScene("Onboarding");
        }

        public void QuitGame()
        {
            Application.Quit();
        }
    }
}
