using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    internal static GameObject bugcardPrefab;
    [SerializeField] internal GameObject bugPrefab;
    internal static GameObject itemcardPrefab;
    [SerializeField] internal GameObject itemPrefab;
    internal static GameObject mutationcardPrefab;
    [SerializeField] internal GameObject mutationPrefab;



    void Start()
    {
        bugcardPrefab = bugPrefab;
        itemcardPrefab = itemPrefab;
        mutationcardPrefab = mutationPrefab;
    }

    void Update()
    {
        
    }

    public GameObject AttachCardScript(GameObject card, CardBase script)
    {
        
    }
}
