using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOut : MonoBehaviour
{
    private IEnumerator Fade() 
    {
        // MaterialのRendering modeをfadeにしないと透明度が変化しない
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
