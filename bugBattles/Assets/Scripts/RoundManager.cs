using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundManager : MonoBehaviour
{
    public GameObject manager;
    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("Manager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void DamageCard(int attackAmount, GameObject card)
    {
        CardInfo cardinfo = card.GetComponent<CardInfo>();
        
        manager.GetComponent<ItemInfo>().ItemEffect(cardinfo, cardinfo.itemID);
        manager.GetComponent<MutationInfo>().MutationEffect(cardinfo, cardinfo.mutationID);
    }
}
