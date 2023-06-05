using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Diagnostics.CodeAnalysis;
using Unity.VisualScripting;

public class CardInfo : MonoBehaviour
{
    //variables
    public int playerID;
    public int cardID;

    public int health;
    public int attack;
    public int tier;
    public int science;


    public int mutationID;
    public int itemID;

    // children
    public GameObject visuals;

    private void OnMouseDown()
    {
        if (true)
        {
            //check if its the current players turn and that there is no card on the battlefield, if thats true then when clicked, put the card onto battlefield
        }
    }

    private void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }


}
