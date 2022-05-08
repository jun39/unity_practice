using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class FadeOut : MonoBehaviour
{
   

    // Rendermodeの種類
    // https://qiita.com/waken/items/e8199effe7d2e07e4f29
    // イテレーターはyield returnの続きから処理を再開し続ける。中断されたところから処理を再開
    private IEnumerator Fade() 
    {
        
        
        // MaterialのRendering modeをfadeにしないと透明度が変化しない
        // 消えたり、現れたりする敵がこれで作れる
    for (float ft = 1f; ft >= 0; ft -= 0.1f) 
        {
        Color c = GetComponent<Renderer>().material.color;
        c.a = ft;
        Debug.Log(ft);
        GetComponent<Renderer>().material.color = c;
        yield return new WaitForSeconds(.1f);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow)) 
        {
        StartCoroutine("Fade");
        }
    }

}
