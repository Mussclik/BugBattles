using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    public static Vector2[] cardIDs;
    public static Vector2[] cardIDsVisable;
    public static bool noMoreCardsInDeck = false;

    private void Update()
    {
      //  cardIDsVisable = cardIDs;
      //  if (cardIDs.Length <= 0 )
      //  {
      //      noMoreCardsInDeck = true;
      //      Destroy(gameObject.transform.GetChild(0).gameObject);
      //  }
    }

    public void DrawCard()
    {
        
    }

}
