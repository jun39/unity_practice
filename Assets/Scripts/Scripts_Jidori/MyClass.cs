using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// ActionやFuncなどの標準ライブラリのデリゲートはSystem名前空間にある
using System;

public class MyClass
{
    public int myLevel;
    public Vector3 myPosition;
    public string myrName;

    public void JsonProcess(string json,Action<string> action){
        action(json);
    }
    
}