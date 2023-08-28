using System.Collections;
using System.Collections.Generic;
using testinging;
using UnityEngine;
using TMPro;
using System.Linq;
using CardParts;
using Unity.VisualScripting;

public class BugCard : MonoBehaviour
{
    //basic vars
    int iD;
    int tier;
    int cost;
    Attack attack = new Attack();
    //int attack; redundent
    int health;
    string family;
    int weakness;
    int shield;
    int maxHealth; //for healthbar
    int maxShield; //for healthbar
    public int status;

    [SerializeField]
    bool debugtest = false;
    [SerializeField]
    int debugID;
    

    public Vector3 desiredPos;
    public Vector3 desiredRotation;

    GameObject manager;
    public VisualCard visuals;

    //turn phases deligates
    public delegate void TurnPhasess(BugCard thisCard);
    public event TurnPhasess preAttack;
    public event TurnPhasess postAttack;


    Attack test = new Attack(1, 2, 3); // creates an attack class with damage = 1, penetration = 2, type = 3, if nothing is entered then default to 0

    public void UpdateID(int newID)
    {
        iD = newID;
        InitializeCards initializeCards = manager.GetComponent<InitializeCards>();
        copyCardStats(initializeCards.creatureList.ElementAt(newID));
        //clear all the deligates
        //send like GetNewDeligates(newID, this.gameObject) to manager for card abilities
    }

    void UpdateVisuals()
    {
        visuals.tier.text = tier.ToString();
        visuals.cost.text = cost.ToString();
        visuals.cardType.text = "creature";
        visuals.attack.text = attack.GetDamage().ToString();
        visuals.health.text = health.ToString();
        if (family.ToLower() == "null")
        {
            visuals.family.text = "";
        }
        else
        {
            visuals.family.text = family;
        }
    }

    void copyCardStats(InitializeCards.CreatureCard newInfo)
    {
        tier = newInfo.tier;
        cost = newInfo.cost;
        attack.SetDamage(newInfo.baseAttack);
        health = newInfo.baseHealth;
        family = newInfo.family;
        weakness = newInfo.weakness;

        visuals.cardName.text = newInfo.name;
        visuals.Description.text = newInfo.description;

        UpdateVisuals();
    }

    

    public void TakeDamage(int amount, int damagetype = 0)
    {

    }

    void OnMouseOver()
    {

    }

    private void Start()
    {
        manager = GameObject.FindGameObjectWithTag("Manager");
    }

    private void Update()
    {
        Debugtest();
    }
    void Debugtest()
    {
        if (debugtest)
        {
            try
            {
                UpdateID(debugID);
            }
            catch
            {
                debugtest = false;
                UpdateID(0);
                UnityEngine.Debug.LogWarning("an error has occurred on " + this.gameObject.name);
            }
        }
    }

}
