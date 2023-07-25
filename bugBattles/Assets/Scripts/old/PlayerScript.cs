using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public static int currentPlayerTurn;

    public int playerID;
    public int currentScience;

    public GameObject frontCard;
    public GameObject backCards;
    public GameObject Deck;
    public GameObject manager;

    public CardInfo[] allCards;
    public bool noCardOnFront;
    public bool lostGame;
    bool firstTurn = true;
    
    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("Manager");
        BeginTurnActions();
    }

    // Update is called once per frame
    void Update()
    {
        if (noCardOnFront)
        {
            //allow trying to add cards to front, enable onmouse down on cardinfos to call addcardtofront
        }

        if (lostGame == true)
        {
            manager.GetComponent<RoundManager>().EndGame(playerID);
        }
    }

    public void BeginTurnActions()
    {
        allCards = gameObject.transform.GetComponentsInChildren<CardInfo>();
        foreach (CardInfo card in allCards)
        {
            card.playerID = playerID;
            card.currentOwner = gameObject.GetComponent<PlayerScript>();
        }
        Debug.Log(frontCard.transform.childCount + " " + gameObject.name);
        if (frontCard.transform.childCount < 1 )
        {
            noCardOnFront = true;
            CardInfo[] temp = backCards.GetComponentsInChildren<CardInfo>();
            lostGame = true;

            foreach (CardInfo card in temp)
            {
                if (card.cardType == 0)
                {
                    lostGame = false;
                }
            }

            //can start next turn = false
        }
    }

    public void AddCardToFront(GameObject card)
    {
        if (card.GetComponent<CardInfo>().playerID == playerID)
        {
            Debug.Log("addcardtofront");
            card.gameObject.transform.parent = frontCard.transform;
            card.transform.localPosition = Vector3.zero;
            //can start next turn = true
            noCardOnFront = false;
        }
    }

    public void TakeDamage(int attackAmount)
    {
        if (firstTurn == true)
        {
            firstTurn = false;
        }
        else
        {
            frontCard.GetComponentInChildren<CardInfo>().health -= attackAmount;
        }

    }

    public int GiveDamageAmount()
    {
        return frontCard.GetComponentInChildren<CardInfo>().attack;
    }

}
