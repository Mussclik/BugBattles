using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugCard : CardBase
{
    //vars
    internal int baseAttack;
    internal int finalAttack;
    internal int baseHP;
    internal int finalHP;
    internal int baseShield;
    internal int finalShield;
    internal int cost;
    internal int tier;

    //objects
    internal List<EffectBase> preAttack;
    internal List<EffectBase> postAttack;
    internal List<EffectBase> onetimeUse;

    internal BugCard()
    {

    }

    internal override void Start()
    {
        
    }

    internal override void Update() //probably only to be used to check if mouse is over or not or clicked on.
    {
        
    }
}
