using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
// ActionやFuncなどの標準ライブラリのデリゲートはSystem名前空間にある
using System;




public class JsonGet : MonoBehaviour
{

// jsonをコマンドラインに表示するメソッド
    // static void JsonPrint(string json){
    //     Debug.Log(json);
    // }


    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(GetText());
// MyClassを外部で作って、そのクラスをjsonに変更できるかを試した。
        MyClass myObject = new MyClass();
        Debug.Log(myObject.myName);
        
        myObject.SayHello();
        myObject.SayHello(true);

        string json = JsonUtility.ToJson(myObject);
        myObject.JsonProcess(json,(string json)=>
        {
            Debug.Log(json);
        });


    }

// ここらへんのIEnumeratorがまとめて他のクラスでつくれてインスタンス化して、外部クラスから使えるか調べる
// C#におけるインターフェースを調べる。あとSystem空間に何があるか
// 自分でもインターフェースを作ってみる
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



