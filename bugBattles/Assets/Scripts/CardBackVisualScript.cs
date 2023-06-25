using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class CardBackVisualScript : MonoBehaviour
{
    CardInfo[] cards;
    public int numberOfChildren = 0;
    public float minDistance;
    public float maxDistance;
    public KeyCode debugkey;
    public float zOffset;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        cards = GetComponentsInChildren<CardInfo>();
        if (numberOfChildren != cards.Length);
        {
            ReSort(gameObject);
            numberOfChildren = cards.Length;
        }

    }

    public void ReSort(GameObject objectOfTheGame) // should get called anytime a card is added or removed as child, or whenever the script detects a change in children
    {
        Debug.Log("resort " + numberOfChildren.ToString() + " " + cards.Length.ToString() + " " + objectOfTheGame.name);
        float halfAmount = cards.Length / 2;
        float diffrence;
        float distanceDiffrence;
        float newOffset;
        for (int i = 0; i < cards.Length; i++)
        {
            diffrence = i - halfAmount;
            distanceDiffrence = maxDistance - minDistance;
            newOffset = distanceDiffrence / cards.Length;
            Vector3 newPosition = new Vector3(newOffset * diffrence, cards[i].transform.localPosition.y, zOffset * diffrence);
            cards[i].transform.localPosition = newPosition;

        }
    }
}
