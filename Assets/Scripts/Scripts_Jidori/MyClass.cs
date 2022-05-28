using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// ActionやFuncなどの標準ライブラリのデリゲートはSystem名前空間にある
using System;

public class MyClass
{
    public int myLevel;
    public Vector3 myPosition;
    public string myName;

    public MyClass(int myLevel,Vector3 myPosition,string myName){
        this.myLevel = myLevel;
        this.myPosition = myPosition;
        this.myName = myName;
    }

    public MyClass():this(1,Vector3.zero,"名無しさん"){}

    public void JsonProcess(string json,Action<string> action){
        action(json);
    }

    public void SayHello(){
        SayHello(false);
    }

// Politeは礼儀正しいという意味
// メソッドをオーバーライドしている。SayHelloに引数がない場合は、引数をfalseにしてオーバーライドした引数のあるSayHelloを呼び出す
    public void SayHello(bool polite){
        if(polite){
            Debug.Log(this.myName+"と申します。どうぞよろしくおねがいします");
        }else{
            Debug.Log(this.myName+"だよ。よろしく！");
        }
    }
    
}