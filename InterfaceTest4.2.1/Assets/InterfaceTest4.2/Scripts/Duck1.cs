using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duck1:DuckBase
{
    //base是用来指定执行的父类的带参的构造函数
    public Duck1(IFlyBehavior iFlyBehavior,IQuackBehavior iQuackBehavior):base(iFlyBehavior,iQuackBehavior)
    {
        
    }
    public override void Display()
    {
        Debug.Log("我是1号鸭子！");
    }
}
