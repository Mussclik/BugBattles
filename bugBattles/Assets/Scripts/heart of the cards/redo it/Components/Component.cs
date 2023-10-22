using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Component : MonoBehaviour
{


    public delegate void Deligate();
    public Deligate buh;
    protected event Deligate turnStart, turnAdvance, turnEnd;



    void Start()
    {
        buh = null;
        buh += Method();
    }

    void Method()
    {

    }

    void Update()
    {
        
    }

    internal void TurnStart()
    {
        turnStart();
    }

    internal void TurnAdvance()
    {
        turnAdvance();
    }

    internal void TurnEnd()
    {
        turnEnd();
    }
}
