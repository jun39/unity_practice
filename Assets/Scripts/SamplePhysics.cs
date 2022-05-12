using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SamplePhysics : MonoBehaviour
{
    public float torque;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

     void FixedUpdate()
    {
        torque = 1.0f;
        // float turn = Input.GetAxis("Horizontal");
        // rb.AddTorque(transform.up*10.0f);
        // rb.AddTorque(transform.right*10.0f);
        rb.AddTorque(transform.forward*10.0f);

        // rb.AddForce(transform.up*10.0f);

    }

    // Update is called once per frame
    void Update()
    {
        rb.mass +=0.001f;
    }
}
