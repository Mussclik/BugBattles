using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCard : MonoBehaviour
{
    //variables
    internal string name;
    internal string description;
    internal int id;
    internal int playerID;
    internal bool active;


    //objects
    internal GameObject manager;
    internal GameObject player;
    internal List<Component> components;

    //constructor
    internal BaseCard()
    {
        name = "";
        description = "";
        id = -2;
        playerID = 0;
        active = false;

        manager = null;
        player = null;
        components = new List<Component>();
        components.Add(new VisualComponent());
    }

    //properties

    //methods
    void Start()
    {
        ManagerR.Log($"[{this.gameObject.name}: Running Front()]");
        manager = GameObject.FindGameObjectWithTag("manager");
    }

    void Update() //check if clicked
    {

    }

    internal virtual void Front()
    {
        ManagerR.Log("[BaseCard: Running Front()]");

    }
    internal virtual void Back()
    {
        ManagerR.Log("[BaseCard: Running Back()]");
    }
}
