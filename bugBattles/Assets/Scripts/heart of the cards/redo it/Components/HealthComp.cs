using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthComp : Component
{
    private int health;
    private int shield;
    private int weakness;
    private int status;

    public HealthComp(int health = 1, int shield = 0, int weakness = 0, int status = 0)
    {
        this.health = health;
        this.shield = shield;
        this.weakness = weakness;
        this.status = status;
    }

    #region Properties
    internal int Health
    {
        get 
        { 
            return health; 
        }
        set 
        {
            health = value; 
        }
    }
    public int Shield
    {
        get 
        {
            return shield; 
        }
        set 
        {
            shield = value; 
        }
    }
    internal int Weakness
    {
        get 
        {
            return weakness; 
        }
        set
        {
            weakness = value;
        }
    }
    public int Status
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
