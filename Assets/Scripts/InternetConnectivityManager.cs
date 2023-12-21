namespace ARTreasureHunt
{
    using System.Collections;
    using UnityEngine;
    using UnityEngine.Networking;

    public class InternetConnectivityManager : MonoBehaviour
    {
        private bool shouldCheckInternet = false;
        public GameObject InternetConnectivityDialogBox;

        void Start()
        {
            shouldCheckInternet = true;
            StartCoroutine(CheckInternetAccessInInterval());
        }

        private IEnumerator CheckInternetAccessInInterval()
        {
            while (shouldCheckInternet)
            {
                yield return new WaitForSeconds(5);
                Debug.Log("Checking internet ...");
                CheckInternetAccess();
            }
        }

        void CheckInternetAccess()
        {
            if (Application.internetReachability == NetworkReachability.NotReachable)
            {
                Debug.Log("No Internet ...");
                InternetConnectivityDialogBox.SetActive(true);
                shouldCheckInternet = false;
            }
            else
            {
                StartCoroutine(CheckInternetConnectivityFromServer());
            }
        }

        IEnumerator CheckInternetConnectivityFromServer()
        {
            UnityWebRequest request = new UnityWebRequest("https://www.google.com/");
            yield return request.SendWebRequest();

            if (string.IsNullOrEmpty(request.error))
            {
                Debug.Log("Connected with Internet ...");
            }
            else
            {
                Debug.Log("Coroutine No Internet ...");
                InternetConnectivityDialogBox.SetActive(true);
                shouldCheckInternet = false;
            }
        }
    }
}
