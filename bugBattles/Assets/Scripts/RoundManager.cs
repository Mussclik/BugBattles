using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using TMPro;
using UnityEngine;
using UnityEngine.WSA;

public class RoundManager : MonoBehaviour
{
    public KeyCode nextturn;

    public TextMeshProUGUI currentTurnText;
    public TextMeshProUGUI currentRoundText;
    public TextMeshProUGUI warningText;

    public CardInfo activeCardP1;
    public CardInfo activeCardP2;

    public GameObject p1FrontCardSlot;
    public GameObject p2FrontCardSlot;

    public int currentPlayer;
    public int currentRound;

    int roundcheck;
    public bool startNextTurn;

    public int startingScience;
    public int sciencePerRound;
    int player1Science;
    int player2Science;

    public float frontWarningTime;


    void Start()
    {
        player1Science = startingScience;
        player2Science = startingScience;
        warningText.gameObject.SetActive(false);
    }

    void Update()
    {   
        if (roundcheck >= 2)
        {
            roundcheck = 0;
            currentRound++;
            currentRoundText.text = "Current Round: " + currentRound.ToString();
        }
        currentTurnText.text = "Current Turn: P" + currentPlayer.ToString();   
    }


    public void DamageCard(int attackAmount, CardInfo card)
    {
        CardInfo cardinfo = card;

        //fix later
        attackAmount = gameObject.GetComponent<ItemInfo>().ItemEffect(card, card.itemID, attackAmount);
        attackAmount = gameObject.GetComponent<MutationInfo>().MutationEffect(card, card.mutationID, attackAmount);

        card.health -= attackAmount;

    }

    public void InvokeNextTurn() // used for button to activate next turn wat no way
    {
        if (currentPlayer == 1)
        {
            if (p1FrontCardSlot.transform.childCount > 0)
            {
                activeCardP1 = p1FrontCardSlot.transform.GetChild(0).gameObject.GetComponent<CardInfo>();

                
                //activate special effects for this players card
                DamageCard(activeCardP1.attack, activeCardP2);
                currentPlayer = 2;
                //set PulledCard false
                //add card to player2 deck
                //function that adds card to deck, checks if there are 4 creature cards, if not then allow creature card pulls

            }
            else
            {
                StartCoroutine(PlaceEnemyOntoFront());
            }
        }
        else 
        {
            if (p2FrontCardSlot.transform.GetChild(0).gameObject.GetComponent<CardInfo>() != null)
            {
                activeCardP2 = p2FrontCardSlot.transform.GetChild(0).gameObject.GetComponent<CardInfo>();


                //activate special effects for this players card
                DamageCard(activeCardP2.attack, activeCardP1);
                currentPlayer = 1;
                //set PulledCard false
                //add card to player2 deck
                //function that adds card to deck, checks if there are 4 creature cards, if not then allow creature card pulls
            }
            else
            {
                //check if creatures exist in the back of player, tell player to add battlefuild card if they try to advance turn
                //if no creature in the back
                StartCoroutine(PlaceEnemyOntoFront());
            }
        }

        roundcheck++;
    }

    internal IEnumerator PlaceEnemyOntoFront()
    {
        warningText.gameObject.SetActive(true);
        yield return new WaitForSeconds(frontWarningTime);
        warningText.gameObject.SetActive(false);
    }
}
