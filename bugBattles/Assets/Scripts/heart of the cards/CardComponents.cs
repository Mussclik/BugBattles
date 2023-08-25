using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace CardParts
{
    public class CardComponents : MonoBehaviour
    {
    }
    public class Attack //class
    {
        int damage;
        int penetration;
        int element;
        int status;

        public Attack(int damage = 0, int penetration = 0, int element = 0, int status = 0) //class constructor
        {
            this.damage = damage;
            this.penetration = penetration;
            this.element = element;
            this.status = status;
        }

        //get
        public int GetDamage()
        {
            return damage;
        }
        public int GetPenetration()
        {
            return penetration;
        }
        public int GetElement()
        {
            return element;
        }
        public int GetStatus()
        {
            return status;
        }

        //set
        public void SetDamage(int newDamage)
        {
            this.damage = newDamage;
        }
        public void SetPenetration(int newPenetration)
        {
            this.penetration = newPenetration;
        }
        public void SetElement(int newElement)
        {
            this.element = newElement;
        }
        public void SetStatus(int newStatus)
        {
            this.status = newStatus;
        }

        //default
        public Attack Empty()
        {
            Attack attack = new Attack(0, 0, 0, 0);
            return attack;
        }
    }

    public class Health
    {
        int health;
        int shield;
        int weakness;
        int status;

        private int maxhealth;
        private int maxshield;

        public Health(int health = 1, int shield = 0, int weakness = 0, int status = 0)
        {
            this.health = health;
            this.shield = shield;
            this.weakness = weakness;
            this.status = status;
        }

        public void UpdateMaxValues()
        {
            if (health > maxhealth)
            {
                maxhealth = health;
            }
            if (shield > maxshield)
            {
                maxhealth = shield;
            }
        }

        //get
        public int GetHealth()
        {
            return health;
        }
        public int GetShield()
        {
            return shield;
        }
        public int GetWeakness()
        {
            return weakness;
        }
        public int GetStatus()
        {
            return status;
        }

        //set
        public void SetHealth(int health)
        {
            this.health = health;
        }
        public void SetShield(int shield)
        {
            this.shield = shield;
        }
        public void SetWeakness(int weakness)
        {
            this.weakness = weakness;
        }
        public void SetStatus(int status)
        {
            this.status = status;
        }

        //Default
        public Health Empty()
        {
            return new Health(0,0,0,0);
        }
    }
}

