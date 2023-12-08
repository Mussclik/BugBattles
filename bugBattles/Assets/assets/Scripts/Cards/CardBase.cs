using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardBase : MonoBehaviour
{
    internal int id;
    internal string cardName;
    internal string description;

    internal CardBase()
    {
        id = 0;
        cardName = string.Empty;
        description = string.Empty;
    }


    internal virtual void Start()
    {

    }

    internal virtual void Update()
    {

    }

    internal virtual void LoadId()
    {

    }
    internal virtual void Clear()
    {

    }
    internal virtual void Delete()
    {

    }

}
