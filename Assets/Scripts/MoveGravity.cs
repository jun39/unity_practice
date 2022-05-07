using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGravity : MonoBehaviour
{
     public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
 
    private Vector3 moveDirection = Vector3.zero;
    private CharacterController controller;
 
     void Start()
    {
        controller = GetComponent<CharacterController>();
    }
 
    void Update()
    {
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection = moveDirection * speed;
 
            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }
        }
        // 重力の影響をy軸に加味する
        moveDirection.y = moveDirection.y - (gravity * Time.deltaTime);
        // 時間の変化分だけ進む
        controller.Move(moveDirection * Time.deltaTime);
    }
}


