using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ListBasic : MonoBehaviour
{
    List<int> list = new List<int>{1,4,5};
    static string[] verbs = new string[]{"はいあ","いえい"};
    LinkedList<string> listlink = new LinkedList<string>(verbs);

    HashSet<string> friendsA = new HashSet<string> {"taro","Mickal","jun"};
    HashSet<string> friendsB = new HashSet<string> {"taro","Mickal","Hanako"};

 
    void Start()
    {
        
        Debug.Log(list.Count);
        var templist=listlink.ToArray();
        foreach(var v in templist){
            Debug.Log(v);
        }
        friendsA.IntersectWith(friendsB);
        string[] tempSet = new string[2];
        friendsA.CopyTo(tempSet);
        Debug.Log (tempSet[0]);
        Debug.Log (tempSet[1]);

        


    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
