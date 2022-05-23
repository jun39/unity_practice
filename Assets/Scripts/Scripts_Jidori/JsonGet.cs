using System.Collections;
using UnityEngine;
using UnityEngine.Networking;


public class JsonGet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GetText());
    }

    IEnumerator GetText() {
        // UnityWebRequest www = UnityWebRequest.Get("https://www.my-server.com");
        UnityWebRequest wwwReddit = UnityWebRequest.Get("https://api.pushshift.io/reddit/search/comment/?q=science");
        yield return wwwReddit.SendWebRequest();
 
        if (wwwReddit.result != UnityWebRequest.Result.Success) {
            Debug.Log(wwwReddit.error);
        }
        else {
            // Show results as text
            Debug.Log(wwwReddit.downloadHandler.text);
 
            // Or retrieve results as binary data
            byte[] results = wwwReddit.downloadHandler.data;
        }
    }

}
