using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTime : MonoBehaviour
{
        public float distancePerFrame;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        // transform.Translate(0, 0, distancePerFrame); // this is incorrect
        transform.Translate(distancePerFrame*Time.deltaTime, 0,0); // correct
        transform.Translate(0, 0, distancePerFrame * Time.deltaTime);

    }
}
