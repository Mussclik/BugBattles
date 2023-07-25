using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class credits : MonoBehaviour
{
    public GameObject otherCredits;


    private void OnEnable()
    {
        otherCredits.SetActive(true);
    }

    private void OnDisable()
    {
        otherCredits.SetActive(false);
    }
}
