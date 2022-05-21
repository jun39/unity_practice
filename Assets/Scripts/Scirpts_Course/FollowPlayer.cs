using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;

    private Vector3 offset = new Vector3(0, 5, 7);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //�J��������ɎԂ������͂��Ȃ̂�LateUpdate
    // Update is called once per frame
    void LateUpdate()
    {
        transform.LookAt(player.transform);
        transform.position = player.transform.position +offset;
    }
}
