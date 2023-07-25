using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfirmOrInspectInfo : MonoBehaviour
{
    public GameObject cardsAndBackdrop;
    public GameObject creatureSlot;
    public GameObject mutationSlot;
    public GameObject itemSlot;

    public GameObject canvasButtons;
    public GameObject confirmFrontButton;
    public GameObject confirmAddToCardButton;

    public GameObject mutationItemTemplate;
    GameObject[] cardslots;
    public delegate void ConfirmPressed();
    public static event ConfirmPressed confirmPressed;


    public void OpenInspectConfirmMenu(GameObject cardObject, bool frontButtonOn = false) //called by a card on click to inspect card or to place creature onto front, enable the inspect menu things, store the card object,
    {
        if (frontButtonOn)
        {
            confirmFrontButton.SetActive(true);
        }
        GameObject tempCCardVisualsGB;

        tempCCardVisualsGB = Instantiate(cardObject.GetComponent<CardInfo>().visuals, creatureSlot.transform.position, Quaternion.identity, creatureSlot.transform);
        tempCCardVisualsGB.GetComponent<CardVisuals>().enabled = false;
    }

    public void ResetInspectMenu()
    {

    }

    public void ConfirmButton()
    {
        confirmPressed();
    }





    /*
    public void Start()
    {
        cardslots = new GameObject[3];
        cardslots[0] = creatureSlot;
        cardslots[1] = mutationSlot;
        cardslots[2] = itemSlot;
    }
    public void ResetEverything()
    {
        GameObject[] temp;
        //reset cardslots
        foreach (GameObject cardslot in cardslots)
        {
            temp = cardslot.transform.GetComponentsInChildren<GameObject>();
            for (int i = 0; i < temp.Length; i++)
            {
                Destroy(temp[i]);
            }
        }
        cardsAndBackdrop.SetActive(false);


        //reset canvas buttons
        confirmAddToCardButton.SetActive(false);
        confirmFrontButton.SetActive(false);
        canvasButtons.SetActive(false);
    }

    public void AddCards(GameObject creatureCard, int mutationID = 0, int itemID = 0)
    {

    }
    */
}
