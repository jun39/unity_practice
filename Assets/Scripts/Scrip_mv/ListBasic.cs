using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ListBasic : MonoBehaviour
{
    List<int> list = new List<int>{1,4,5};
    static string[] verbs = new string[]{"はいあ","いえい"};
    LinkedList<string> listlink = new LinkedList<string>(verbs);
 
    void Start()
    {
        
        Debug.Log(list.Count);
        var templist=listlink.ToArray();
        foreach(var v in templist){
            Debug.Log(v);
        }

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
