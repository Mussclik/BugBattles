using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class visualsitemmutation : MonoBehaviour
{
    public bool updating = true;
    itemmutationCard card;
    TextMeshPro name;
    TextMeshPro description;
    TextMeshPro type;
    SpriteRenderer sprite;


    void Update()
    {
        if (updating && card != null)
        {
            if (card.itemCard)
            {
                //update all the tmp's with info from database with the id
            }
            else //mutant card
            {

            }
        }
    }

}
