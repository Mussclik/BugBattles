using CardParts;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using testinging;
using UnityEngine;

public class ItemCard : MonoBehaviour
{
    int iD;
    int cost;
    int tier;

    [SerializeField] int debugID;
    [SerializeField] bool debugtest;

    GameObject manager;
    [SerializeField] VisualCard visuals;
    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("Manager");
    }

    void Update()
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

    VisualCard UpdateVisuals(VisualCard visualcard)
    {
        /*
        visuals.tier.text = itemCard.tier.ToString();
        visuals.cost.text = itemCard.cost.ToString();
        visuals.cardType.text = "item";
        */
        visualcard.tier.text = tier.ToString();
        visualcard.cost.text = cost.ToString();
        visualcard.cardType.text = "Item";
        return visualcard;
    }

    void copyCardStats(InitializeCards.ItemCard newInfo)
    {

        //all stats on itemCard
        tier = newInfo.tier;
        cost = newInfo.cost;

        visuals.cardName.text = newInfo.name;
        visuals.Description.text = newInfo.description;

        visuals = UpdateVisuals(visuals);
    }

    public void UpdateID(int newID)
    {
        iD = newID;
        InitializeCards initializeCards = manager.GetComponent<InitializeCards>();
        copyCardStats(initializeCards.itemList.ElementAt(newID));
        //clear all the deligates
        //send like GetNewDeligates(newID, this.gameObject) to manager for card abilities
    }
}
