using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackComp : Component
{
    private int damage;
    private int penetration;
    private int element;
    private int status;

    internal AttackComp(int health = 1, int shield = 0, int weakness = 0, int status = 0)
    {
        this.damage = health;
        this.penetration = shield;
        this.element = weakness;
        this.status = status;
    }

    #region Properties
    internal int Health
    {
        get
        {
            return damage;
        }
        set
        {
            damage = value;
        }
    }
    internal int Shield
    {
        get
        {
            return penetration;
        }
        set
        {
            penetration = value;
        }
    }
    internal int Weakness
    {
        get
        {
            return element;
        }
        set
        {
            element = value;
        }
    }
    internal int Status
    {
        get
        {
            return status;
        }
        set
        {
            status = value;
        }
    }
    #endregion
}
