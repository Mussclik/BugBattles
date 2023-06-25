using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheWorldsBestFixForBadCodeOnTheFrontCard : MonoBehaviour
{
    void Update()
    {
        CardInfo[] cards;
        if (transform.childCount > 0)
        {
            cards = GetComponentsInChildren<CardInfo>();
            foreach (CardInfo card in cards)
            {
                card.transform.localPosition = Vector3.zero;
            }
        }

    }
}
