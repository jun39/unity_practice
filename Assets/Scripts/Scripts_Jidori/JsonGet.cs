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
        UnityWebRequest www = UnityWebRequest.Get("https://www.my-server.com");
        yield return www.SendWebRequest();
 
        if (www.result != UnityWebRequest.Result.Success) {
            Debug.Log(www.error);
        }
        else {
            // Show results as text
            Debug.Log(www.downloadHandler.text);
 
            // Or retrieve results as binary data
            byte[] results = www.downloadHandler.data;
        }
    }

}
