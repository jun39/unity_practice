using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
   [SerializeField] Transform playerTr; // プレイヤーのTransform

    private void Update() {       
        transform.position = Vector3.Lerp(
            transform.position, 
            playerTr.position + new Vector3(0, 0, -10), // カメラzの位置
            2.0f * Time.deltaTime);  
    }
}
