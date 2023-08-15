using System.Collections;
using System.Collections.Generic;
using testinging;
using UnityEngine;
using TMPro;
using System.Linq;

public class BugCard : MonoBehaviour
{
    //basic vars
    int iD;
    int tier;
    int cost;
    int attack;
    int health;
    string family;
    int weakness;
    int shield;
    int maxHealth; //for healthbar
    int maxShield; //for healthbar

    [SerializeField]
    bool debugtest = false;
    [SerializeField]
    int debugID;
    

    public Vector3 desiredPos;
    public Vector3 desiredRotation;

    GameObject manager;

    //not so basic vars for future
    public delegate void CardTurn();
    public event CardTurn cardTurn;
    public VisualCard visuals;

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
        visuals.attack.text = attack.ToString();
        visuals.health.text = health.ToString();
        if (family != "null" || family != "error")
        {
            visuals.family.text = family;
        }
        else
        {
            visuals.family.text = "";
        }
    }

    void copyCardStats(InitializeCards.CreatureCard newInfo)
    {
        tier = newInfo.tier;
        cost = newInfo.cost;
        attack = newInfo.baseAttack;
        health = newInfo.baseHealth;
        family = newInfo.family;
        weakness = newInfo.weakness;

        visuals.cardName.text = newInfo.name;
        visuals.Description.text = newInfo.description;

        UpdateVisuals();
    }

    public void CardTurnAdvance()
    {
        if (cardTurn != null)
        {
            cardTurn();
        }
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
                Debug.LogWarning("an error has occurred on " + this.gameObject.name);
            }
        }
    }

}
