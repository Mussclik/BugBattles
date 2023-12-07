using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bank : MonoBehaviour
{
    public int currencyStored;
    public bool save = false;
    public bool load = false;

    private void Update()
    {
        if (save)
        {
            save = false;
            SaveBank();
        }
        else if (load)
        {
            load = false;
            LoadBank();
        }
    }

    public void SaveBank()
    {
        SaveSystem.SaveMoney(this);
    }
    public void LoadBank()
    {
        BankData data = SaveSystem.LoadMoney();
        currencyStored = data.money;
    }
}
