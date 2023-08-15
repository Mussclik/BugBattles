using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{

    [SerializeField]
    bool active = false;  
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
        }
    }

    private void accessoarer()
    {
        active = true; 
    }
}
