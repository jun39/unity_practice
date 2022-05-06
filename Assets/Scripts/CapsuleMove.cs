using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class CapsuleMove : MonoBehaviour
{
    public float speed = 3.0F;
    // public float speed = 0.01F;

    public float rotateSpeed = 3.0F;
    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();
        // 左右キー Yを軸として回転
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed,0);
        // 上下キー 前後移動
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        // オブジェクトの向きの座標（transform forward）をローカル座標からワールド座標に変換する
        float curSpeed = speed * Input.GetAxis("Vertical");
        // controller.SimpleMove(forward * curSpeed);
        // Moveの移動量は絶対値、入力した分だけ進む
        controller.Move(forward * curSpeed);

    }
}