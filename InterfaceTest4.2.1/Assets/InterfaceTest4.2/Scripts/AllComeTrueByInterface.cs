using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoFly:IFlyBehavior
{
    public void Fly()
    {
        Debug.Log("不会飞！");
    }
}
public class AllInFly:IFlyBehavior
{
    public void Fly()
    {
        Debug.Log("一直飞！");
    }
}
public class LittleFly:IFlyBehavior
{
    public void Fly()
    {
        Debug.Log("只能飞一点点！");
    }
}

public class GaGaQuack : IQuackBehavior
{
    public void Quack()
    {
        Debug.Log("嘎嘎叫！！");
    }
}
public class NoQuack : IQuackBehavior
{
    public void Quack()
    {
        Debug.Log("不会叫！！");
    }
}
public class ZhiZhiQuack : IQuackBehavior
{
    public void Quack()
    {
        Debug.Log("吱吱叫！！");
    }
}
