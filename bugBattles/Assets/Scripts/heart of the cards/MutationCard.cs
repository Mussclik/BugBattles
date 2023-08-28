using System.Collections;
using System.Collections.Generic;
using System.Linq;
using testinging;
using UnityEngine;

public class MutationCard : MonoBehaviour
{
    int iD;

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

    VisualCard UpdateVisuals(VisualCard visualcard)
    {
        //visualcard.cardType.text = "Mutation";
        return visualcard;
    }

    void copyCardStats(InitializeCards.MutationCard newInfo)
    {
        visuals.cardName.text = newInfo.name;
        visuals.Description.text = newInfo.description;

        visuals = UpdateVisuals(visuals);
    }

    public void UpdateID(int newID)
    {
        iD = newID;
        InitializeCards initializeCards = manager.GetComponent<InitializeCards>();
        copyCardStats(initializeCards.mutationList.ElementAt(newID));
        //clear all the deligates
        //send like GetNewDeligates(newID, this.gameObject) to manager for card abilities
    }
}
