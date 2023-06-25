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
    public TextMeshProUGUI playerlostText;

    public PlayerScript player1;
    public PlayerScript player2;

    public int currentPlayer;
    public int currentRound;

    int roundcheck;
    public bool startNextTurn;

    public int startingScience;
    public int sciencePerRound;

    public float frontWarningTime;
    bool startedturn;
    bool newturn;


    void Start()
    {
        player1.currentScience = startingScience;
        player1.currentScience = startingScience;
        warningText.gameObject.SetActive(false);
        startedturn = true;
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

    public void InvokeNextTurn() // used for button to activate next turn wat no way
    {

        newturn = false;
        if (currentPlayer == 1) //player 1
        {
            if (startedturn == true)
            {
                startedturn = false;
                player1.BeginTurnActions();
            }
            if (!player1.noCardOnFront)
            {
                CardInfo frontCard = player1.frontCard.GetComponent<CardInfo>();
                CardInfo enemyFrontCard = player2.frontCard.GetComponent<CardInfo>();
                //activate special effects for this players card
                player2.TakeDamage(player1.GiveDamageAmount()); /* add += extra mutation/item attack */
                currentPlayer = 2;
                //set PulledCard false
                //add card to player2 deck
                //function that adds card to deck, checks if there are 4 creature cards, if not then allow creature card pulls
                startedturn = true;

                roundcheck++;

            }
            else
            {
                StartCoroutine(PlaceEnemyOntoFront());
            }
        }

        else //player2
        {
            if (startedturn == true)
            {
                startedturn = false;
                player2.BeginTurnActions();
            }
            if (!player2.noCardOnFront)
            {
                //activate special effects for this players card
                player1.TakeDamage(player2.GiveDamageAmount()); /* add += extra mutation/item attack */
                currentPlayer = 1;
                //set PulledCard false
                //add card to player2 deck
                //function that adds card to deck, checks if there are 4 creature cards, if not then allow creature card pulls
                startedturn = true;

                roundcheck++;
            }
            else
            {
                StartCoroutine(PlaceEnemyOntoFront());
            }
        }

        player1.BeginTurnActions();
        player2.BeginTurnActions();
    }

    internal IEnumerator PlaceEnemyOntoFront()
    {
        if (warningText.gameObject != null)
        {
            warningText.gameObject.SetActive(true);
            yield return new WaitForSeconds(frontWarningTime);

            if (warningText.gameObject != null)
            {
                warningText.gameObject.SetActive(false);
            }
        }
    }

    public void EndGame(int playerID)
    {
        warningText.gameObject.SetActive(false);
        playerlostText.gameObject.SetActive(true);
        playerlostText.text = "P" + playerID.ToString() + " Lost, suck shit loser";

        //display text saying who won
        //disable interaction with the game
        //send back to menu
    }

    public void ConfirmationCreature(GameObject cardVisualGameObject) //copy card visuals and add cancel button, and confirm button, confirm place to front
    {

    }

    public void OpenInspector(GameObject cardGameObject)
    {
        //clear out previous





    }
}
