using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Diagnostics.CodeAnalysis;
using Unity.VisualScripting;

public class CardInfo : MonoBehaviour
{
    public GameObject manager;
    //variables
    public int cardID;
    public int mutationID;
    public int itemID;

    public int cardType;
    //0 = creature
    //1 = item
    //2 = mutation
    //or can have it if cardid = 0 then its a mutation card, if mutationid is 0 then its an item card


    public int health;
    public int attack;
    public int tier;
    public int science;

    public int playerID;

    public PlayerScript currentOwner;


    // children
    public GameObject visuals;

    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("Manager");
    }
    void Update()
    {
        if (health <= 0)
        {
            currentOwner.noCardOnFront = true;
            Destroy(gameObject);
        }
    }

    private void OnMouseOver()
    {
        Debug.Log("mose over card");
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("mose clicked card");
            if (currentOwner.noCardOnFront && manager.GetComponent<RoundManager>().currentPlayer == playerID)
            {
                currentOwner.AddCardToFront(gameObject);
            }
        }

    }

    private void OnMouseEnter()
    {
        // increase size and increase y value
    }




}
