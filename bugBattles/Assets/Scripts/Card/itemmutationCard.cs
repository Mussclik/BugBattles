using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class itemmutationCard : MonoBehaviour
{
    public int cardID;
    public bool itemCard;
    public GameObject visuals;
    public GameObject mutationTemplate;
    public GameObject itemTemplate;
    void OnEnable()
    {
        if (visuals == null && cardID != 0)
        {
            if (itemCard)
            {
                visuals = Instantiate(itemTemplate, transform);
            }
            else
            {
                visuals = Instantiate(mutationTemplate, transform);
            }
        }
    }
}
