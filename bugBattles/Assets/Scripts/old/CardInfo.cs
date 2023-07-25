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
        if (Input.GetMouseButtonDown(0)) //leftclick
        {
            Debug.Log("mose clicked card");

            if (cardID != 0)  //bugcard, main thing, on confirm it should move card from back to front
            {

            }
            else if (mutationID != 0) //mutationcard, apply to creature card and delete this one
            {

            }
            else //itemcard, same as mutation card
            {

            }
            /*
            if (currentOwner.noCardOnFront && manager.GetComponent<RoundManager>().currentPlayer == playerID)
            {
                currentOwner.AddCardToFront(gameObject);
            }
            */
        }

        if (Input.GetMouseButtonDown(1)) //rightclick, open inspect
        {
           
        }

    }

    private void OnMouseEnter()
    {
        // increase size and increase y value
    }




}
