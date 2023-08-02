using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using Unity.VisualScripting;

namespace testinging //collection of classes, like the class rigidbody in namespace UnityEngine
                     //access from other scripts with either namespace.class.method() or at the top using.namespace
{


    public class testing : MonoBehaviour
    {

        [Serializable] class Information
        {
            public string name;
            public int cardId; //redundent(?)
            public string description;
            public int baseAttack;
            public int baseHealth;
            public int cardType;
            public int tier;
            public int cost;

            public Information Empty()
            {
                return new Information()
                {
                    name = "",
                    cardId = 0,
                    description = "",
                    baseAttack = 0,
                    baseHealth = 0,
                    cardType = 0,
                    tier = 0,
                    cost = 0
                };
            }

        }
        [Header("god i want to die")]
        [SerializeField] TextAsset textFile;
        [SerializeField] string[] names;
        [Header("Card datas")]
        [SerializeField] Information[] information;


        private void OnValidate() //this be stoled
        {
            
            // the ? is a short way of asking if it does not equal null then continue, if it does equal null then return names = null
            names = textFile ? textFile.text.Split(new[]
            { 
                Environment.NewLine 
            }, StringSplitOptions.RemoveEmptyEntries) : null; // if texfile equals true then it makes a new split every new line, also remove empty lines as an addon(?) and if it equals false return null

            information = new Information[names.Length];
            for (int i = 0; i < information.Length; i++)
            {
                Debug.Log(names.Length +"nameslenght");
                Debug.Log(i + "i");
                Debug.Log(information.Length + "infolenght");
                information[i] = ConvertTextToVars(names[i]);
                
            }
        }

        private Information ConvertTextToVars(string line)
        {
            string[] parts = line.Split(","); // turns a string into array depending on the Split() parameters
            Debug.Log(parts.Length + "parts");
            return new Information
            {
                name = parts[0],
                cardId = int.TryParse(parts[1], out int output ) ? output : 0, //uuuuhhhh, i think so int.tryparse(string, output int) ?(if)  truevalue : falsevalue     so if tryparse returns true, the line will give whats left of the :, but if false then it returns what is to the right.
                description = parts[2],
                baseAttack = int.TryParse(parts[3], out output) ? output : 0, //baseattack = AttemptConvertToInt, if true, return output, if false return 0;     ? output = if true return output,   : 0 = if false return 0
                baseHealth = int.TryParse(parts[4], out output) ? output : 0, // int.TryParse(parts[4]) returns a true/false if it can convert it or not, you can give it an out variable to put the result into
                cardType = int.TryParse(parts[5], out output) ? output : 0, //buh
                tier = int.TryParse(parts[6], out output) ? output : 0,
                cost = int.TryParse(parts[7], out output) ? output : 0
            };
        }
    }
}



