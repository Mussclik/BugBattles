using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Cosmetic : MonoBehaviour
{
    public SpriteRenderer sprite;
    public SpriteRenderer cardframe;
    public TextMeshPro cardName;
    public TextMeshPro description;
    public TextMeshPro family;
    public TextMeshPro attack;
    public TextMeshPro health;
    public TextMeshPro tier;
    public TextMeshPro cost;

    public void ReFetchObjects()
    {
        GameObject[] children = new GameObject[transform.childCount];
        for (int i = 0; i < transform.childCount; i++) 
        {
            children[i] = transform.GetChild(i).gameObject;
        }
        
        foreach (GameObject child in children)
        {
            try
            {
                switch (child.name)
                {
                    case "sprite":
                        sprite = child.GetComponent<SpriteRenderer>();
                        break;

                    case "frame":
                        cardframe = child.GetComponent<SpriteRenderer>();
                        break;

                    case "name":
                        cardName = child.GetComponent<TextMeshPro>();
                        break;

                    case "Description":
                        description = child.GetComponent<TextMeshPro>();
                        break;

                    case "Family":
                        family = child.GetComponent<TextMeshPro>();
                        break;

                    case "Attack":
                        attack = child.GetComponent<TextMeshPro>();
                        break;

                    case "Health":
                        health = child.GetComponent<TextMeshPro>();
                        break;

                    case "Tier":
                        tier = child.GetComponent<TextMeshPro>();
                        break;

                    case "Cost":
                        cost = child.GetComponent<TextMeshPro>();
                        break;

                    default:
                        Debug.Log($"[{gameObject.name}.Cosmetic.ResetValues: no correct name found]");
                        break;
                }
            }
            catch
            {
                Debug.Log($"[{gameObject.name}.Cosmetic.ResetValues: Try/Catch failed]");
            }

        }

    }
    public void UpdateValues()
    {

    }
    public void UpdateValues(CardBase cardinfo)
    {
        if (cardinfo is BugCard bugcard) 
        {

        }
        else if (cardinfo is ItemCard itemcard)
        {

        }
        else if (cardinfo is MutationCard mutationcard)
        {
            //update sprite image
            cardframe =
        }
        else
        {
            Debug.Log($"[{gameObject.name}.Cosmetic.UpdateValuse|2|: failed to match to a cardtype, did you input a CardBase?]");
        }
    }

}
