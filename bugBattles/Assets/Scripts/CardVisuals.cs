using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CardVisuals : MonoBehaviour
{
    //this will look at card info and change visuals like sprites and health accordingly

    public bool creaturecard;
    public bool itemcard;
    public bool mutationcard;

    public SpriteRenderer insectSprite;
    public TextMeshPro typeText;

    public TextMeshPro nameText;
    public TextMeshPro description;

    public TextMeshPro tierText;
    public TextMeshPro scienceText;

    public TextMeshPro attackText;
    public TextMeshPro healthText;

    CardInfo card;
    CardTypeIndex cardIndex;
    GameObject manager;



    private void Start()
    {
        manager = GameObject.FindGameObjectWithTag("Manager");

        card = transform.parent.gameObject.GetComponent<CardInfo>();
        cardIndex = manager.GetComponent<CardTypeIndex>();
    }

    void Update()
    {
        if (creaturecard && card != null)
        {
            typeText.text = "la creatura";

            healthText.text = card.health.ToString();
            attackText.text = card.attack.ToString();
            tierText.text = card.tier.ToString();
            scienceText.text = card.science.ToString();

            nameText.text = cardIndex.creaureNames[card.cardID];
            description.text = cardIndex.creatureDescriptions[card.cardID];
        }
    }
}
