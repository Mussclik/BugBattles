using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugCardR : BaseCard
{
    [SerializeField] private bool debugUpdate;

    HealthComp health;
    AttackComp attack;

    internal BugCardR()
    {
        debugUpdate = false;

        health = new HealthComp();
        attack = new AttackComp();
    }

    void Start()
    {
        
    }

    void Update()
    {
        if (debugUpdate)
        {
            debugUpdate = false;
        }
    }

    internal void SendToBack()
    {

    }

    internal void SentToFront()
    {

    }
}
