using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Diagnostics.CodeAnalysis;

public class CardInfo : MonoBehaviour
{
    //variables
    public string cardName;
    public string cardDesciption;
    public int health;
    public int attack;
    bool isdead;
    public bool specialDeath;
    bool onBattle;

    public int mutationID;
    public int itemID;


    //cardlayer variables
    GameObject mutationSlot;
    GameObject ItemSlot;
    bool itemSlotUsed;
    bool mutationSlotUsed;

    // children
    public GameObject visuals;




    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (specialDeath && isdead)
        {
            //yeah, have 30 diffrent fukkin special death effects in other methods :)

        }

    }



    public void PlacedOntoBattle()
    {
        onBattle = true;

    }

    public void AddCardOntop(bool mutation, GameObject cardObject)
    {
        if (mutation)
        {
            mutationSlot = cardObject;
            mutationSlotUsed = true;
        }
        else
        {
            ItemSlot = cardObject;
            mutationSlotUsed = true;
        }
    }
}
