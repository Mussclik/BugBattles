using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugCard : MonoBehaviour
{
    //basic vars
    public int cost;
    public int tier;
    public int attack;
    public int maxHealth;
    public int health;
    public Vector3 desiredPos;
    public Vector3 desiredRotation;



    //not so basic vars for future
    public delegate void CardTurn();
    public event CardTurn cardTurn;
    public VisualCard visuals;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CardTurnAdvance()
    {
        if (cardTurn != null)
        {
            cardTurn();
        }
    }

    public void TakeDamage(int amount, int damagetype = 0)
    {

    }

    void OnMouseOver()
    {
        
    }

}
