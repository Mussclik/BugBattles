using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public static class SaveSystem
{
    public static void SaveMoney(Bank bank)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/playerMoney.sex";
        FileStream stream = new FileStream(path, FileMode.Create);

        BankData data = new BankData(bank);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static BankData LoadMoney()
    {
        string path = Application.persistentDataPath + "/playerMoney.sex";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            BankData data = formatter.Deserialize(stream) as BankData;
            stream.Close();
            return data;
        }
        else
        {
            Debug.Log("savefile not found in " + path);
            return null;
        }
    }
}
