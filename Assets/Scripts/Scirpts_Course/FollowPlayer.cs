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

    //ƒJƒƒ‰‚æ‚èæ‚ÉÔ‚ª“®‚­‚Í‚¸‚È‚Ì‚ÅLateUpdate
    // Update is called once per frame
    void LateUpdate()
    {
        transform.LookAt(player.transform);
        transform.position = player.transform.position +offset;
    }
}
