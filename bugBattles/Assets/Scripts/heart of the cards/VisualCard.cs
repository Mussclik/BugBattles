using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class VisualCard : MonoBehaviour
{
    public SpriteRenderer sprite;
    public TextMeshPro tier;
    public TextMeshPro science;
    public TextMeshPro cardType;
    public TextMeshPro cardName;
    public TextMeshPro Description;
    public TextMeshPro attack;
    public TextMeshPro health;

    public TextMeshPro[] cardStrings = new TextMeshPro[7];
    // 1=tier, 2=cost, 3=
    void Start()
    {
        
    }
    
    void Update()
    {
        
    }
    
}
