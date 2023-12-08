using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MutationBase : EffectBase
{
    internal int useType; //0 preattack, 1 postattack, 2 onetimeuse
    internal bool mutationAssigned;
    internal bool mutation;

    internal MutationBase(int id) : base(id)
    {

    }

    internal void Mutation(BugCard bugcard)
    {
        if (useType == 0)
        {
            bugcard.preAttack.Add(this);
        }
        else if (useType == 1)
        {
            bugcard.postAttack.Add(this);
        }
        else
        {
            bugcard.onetimeUse.Add(this);
        }

    }
}
