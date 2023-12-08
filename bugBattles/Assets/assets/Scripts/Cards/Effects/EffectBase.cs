using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectBase : MonoBehaviour
{
    internal int useCount;
    internal bool used;
    internal int id;

    internal EffectBase(int id)
    {
        this.id = id;
    }

    internal virtual void Effect()
    {
        used = true;
        useCount += 1;

    }
}
