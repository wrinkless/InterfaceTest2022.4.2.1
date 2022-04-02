using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowDuck : MonoBehaviour
{
    void Start()
    {
        var  dack=new Duck1(new NoFly(),new NoQuack());
        dack.Display();
        dack.PerformFly();
        dack.PerformQuack();
        dack.iFlyBehavior=new AllInFly();
        dack.iQuackBehavior=new GaGaQuack();
        dack.Display();
        dack.PerformFly();
        dack.PerformQuack();
    }
    
    
}
