namespace ARTreasureHunt
{
    using TMPro;
    using UnityEngine;

    public class ShowCue : MonoBehaviour
    {
        [SerializeField] GameObject ShowCueBox;
        [SerializeField] TMP_Text Hint;

        public void OnItemClicked()
        {
            if (gameObject.name == "Christmas Tree Icon")
            {
                Hint.text = "Begin your journey where you stand strong. Seek the first treasure along the main road; it won't take long";
                ShowCueBox.SetActive(true);
            }
            else if (gameObject.name == "Present Box Icon")
            {
                Hint.text = "You're on the right track, just 50 steps away. Look around, don't delay. The second treasure is close, where you stand today";
                ShowCueBox.SetActive(true);
            }
            else if (gameObject.name == "Santa Hat Icon")
            {
                Hint.text = "Watch out for signs that say 'No Parking.' The third treasure is there, it's not harking. Find it near where cars are forbidden, and your treasure hunt skills will be truly hidden";
                ShowCueBox.SetActive(true);
            }
            else if (gameObject.name == "Gingerbread Icon")
            {
                Hint.text = "Take a detour, explore the unknown. Head towards a side road where the fourth treasure is sown";
                ShowCueBox.SetActive(true);
            }
            else if (gameObject.name == "Candy Cane Icon")
            {
                Hint.text = "To the heart of the city, where structures stand tall. In front of a building, the fifth treasure will call";
                ShowCueBox.SetActive(true);
            }
            else
            {
                ShowCueBox.SetActive(false);
            }
        }
    }
}
