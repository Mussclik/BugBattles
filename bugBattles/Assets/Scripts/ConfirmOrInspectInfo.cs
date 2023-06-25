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
    GameObject[] cardslots;


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
}
