using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// youtubeのコメントなどが自撮りゲームのuGUIに反映させるスクリプトを書く
// オブジェクトを追加する
public class ChatGUI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Save saveclass = new Save();
        saveclass.WriteData();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
