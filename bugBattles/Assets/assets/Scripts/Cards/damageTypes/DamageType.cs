using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageType : MonoBehaviour
{
    internal static float strength;
    internal DamageType()
    {
        strength = 0.25f;
    }
    internal virtual void Effective()
    {

    }
    internal virtual void Weak()
    {

    }
}
