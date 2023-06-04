using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using TMPro;
using UnityEngine;

public class RoundManager : MonoBehaviour
{
    public KeyCode debugTest;

    public TextMeshProUGUI currentTurnText;

    public CardInfo activeCardP1;
    public CardInfo activeCardP2;

    public int currentPlayer;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(debugTest))
        {
            if (currentPlayer == 1)
            {
                currentPlayer = 2;

                DamageCard(activeCardP1.attack, activeCardP2);
            }
            else
            {
                currentPlayer = 1;

                DamageCard(activeCardP2.attack, activeCardP1);
            }
        }
        /*
        Debug.Log(currentTurnText.gameObject.name);
        Debug.Log(currentPlayer);
        currentTurnText.text = "Current Turn: " + currentPlayer.ToString();
        */
    }


    public void DamageCard(int attackAmount, CardInfo card)
    {
        CardInfo cardinfo = card;

        //fix later
        attackAmount = gameObject.GetComponent<ItemInfo>().ItemEffect(card, card.itemID, attackAmount);
        attackAmount = gameObject.GetComponent<MutationInfo>().MutationEffect(card, card.mutationID, attackAmount);

        card.health -= attackAmount;

    }

}
