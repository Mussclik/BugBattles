using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    [SerializeField] Color unSelected;
    [SerializeField] Color Selected;
    [SerializeField] List<GameObject> buttons;
    [SerializeField] List<GameObject> subDirectories;



    private void Start()
    {
        OpenTab(0);
    }

    private void ResetAll()
    {
        for (int i = 0; i < buttons.Count; i++)
        {
            Debug.Log(i);
            buttons[i].GetComponent<Image>().color = unSelected;
            try
            {
                subDirectories[i].SetActive(false);
            }
            catch
            {
                Debug.Log("lmao eror");
            }
            
        }
    }

    public void OpenTab(int tab)
    {
        ResetAll();

        try
        {
            buttons[tab].GetComponent<Image>().color = Selected;
        }
        catch
        {
            Debug.LogWarning("OutOfBound in menu buttons");
        }
        try
        {
            subDirectories[tab].SetActive(true);
        }
        catch
        {
            Debug.LogWarning("OutOfBound in menu Subdirectory");
        }

    }
}
