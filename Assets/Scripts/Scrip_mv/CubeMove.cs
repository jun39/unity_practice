using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
   
   void Start() {

       Time.timeScale = 0.1f;
   }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0.05f,0,0);
    }
}
