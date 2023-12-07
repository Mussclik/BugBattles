using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BankData 
{

    public int money;

    public BankData(Bank bank)
    {
        money = bank.currencyStored;
    }
}
