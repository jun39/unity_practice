using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HingeMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dx = Input.GetAxis("Horizontal") * Time.deltaTime * 3;
        float dz = Input.GetAxis("Vertical") * Time.deltaTime * 3;
        transform.position = new Vector3 (
        transform.position.x + dx, 4, transform.position.z + dz
        );
    }
}
