using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 鸭子的基类（抽象类）
/// </summary>
public  abstract class DuckBase
{
    public IFlyBehavior iFlyBehavior {private get; set; }
    public IQuackBehavior iQuackBehavior { private get; set; }

    /// <summary>
    /// 构造函数
    /// </summary>
    /// <param name="iFlyBehavior">实现飞行接口的实例</param>
    /// <param name="iQuackBehavior">实现鸭子叫的接口的实例</param>
    protected  DuckBase(IFlyBehavior iFlyBehavior=null,IQuackBehavior iQuackBehavior=null)
    {
        this.iFlyBehavior = iFlyBehavior;
        this.iQuackBehavior = iQuackBehavior;
    }
    
    public abstract void Display();

    /// <summary>
    /// 执行飞行行为
    /// </summary>
    public void PerformFly()
    {
        iFlyBehavior.Fly();
    }

    /// <summary>
    /// 执行鸭子叫行为
    /// </summary>
    public void PerformQuack()
    {
        iQuackBehavior.Quack();
    }
}
