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


    public class InitializeCards : MonoBehaviour
    {

        [Serializable] class CreatureCard
        {
            public string name;
            public string description;
            public int baseAttack;
            public int baseHealth;
            public int tier;
            public int cost;

            public CreatureCard Empty()
            {
                return new CreatureCard() 
                {
                    name = "",
                    description = "",
                    baseAttack = 0,
                    baseHealth = 0,
                    tier = 0,
                    cost = 0
                };
            }
        }
        [Serializable] class ItemCard
        {
            public string name;
            public string description;
            public int tier;
            public int cost;

            public CreatureCard Empty()
            {
                return new CreatureCard()
                {
                    name = "",
                    description = "",
                    tier = 0,
                    cost = 0
                };
            }
        }
        [Serializable] class MutationCard
        {
            public string name;
            public string description;
            
            public MutationCard Empty()
            {
                return new MutationCard()
                {
                    name = "",
                    description = ""
                };
            }
        }


        [Header("creaturecards data")]
        [SerializeField] string[] lines;
        string cardType;

        [SerializeField] TextAsset creatureCardList, itemCardList, mutationCardList;
        [SerializeField] CreatureCard[] creatureCard;
        [SerializeField] ItemCard[] itemCard;
        [SerializeField] MutationCard[] mutationCard;

        [SerializeField] List<CreatureCard> creatureList; 
        [SerializeField] List<ItemCard> itemList; 
        [SerializeField] List<MutationCard> mutationList; 


        private void OnValidate() //this be stoled
        {
            
            // the ? is a short way of asking if it does not equal null then continue, if it does equal null then return lines = nulll
            lines = creatureCardList ? creatureCardList.text.Split(new[]
            { 
                Environment.NewLine 
            }, StringSplitOptions.RemoveEmptyEntries) : null; // if creaturecardlist equals true then it makes a new split every new line, also remove empty lines as an addon(?) and if it equals false return null

            if (lines != null)
            {
                cardType = lines[0]; //buh buh

                switch(cardType)
                {
                    case "c": //creature card

                        break;

                    case "i":

                        break;

                    case "m":

                        break;

                    default:

                        break;
                }

                creatureCard = new CreatureCard[lines.Length];
                for (int i = 0; i < creatureCard.Length; i++)
                {
                    Debug.Log(lines.Length + "lineslenght");
                    Debug.Log(i + "i");
                    Debug.Log(creatureCard.Length + "infolenght");
                    creatureCard[i] = ConvertCreatureText(lines[i]);
                }
            }

        }

        private CreatureCard ConvertCreatureText(string line)
        {
            string[] parts = line.Split(","); // turns a string into array depending on the Split() parameters
            Debug.Log(parts.Length + "parts");
            return new CreatureCard
            {
                name = parts[0],
                 //uuuuhhhh, i think so int.tryparse(string, output int) ?(if)  truevalue : falsevalue     so if tryparse returns true, the line will give whats left of the :, but if false then it returns what is to the right.
                description = parts[1],
                baseAttack = int.TryParse(parts[2], out int output) ? output : 0, //baseattack = AttemptConvertToInt, if true, return output, if false return 0;     ? output = if true return output,   : 0 = if false return 0
                baseHealth = int.TryParse(parts[3], out output) ? output : 0, // int.TryParse(parts[4]) returns a true/false if it can convert it or not, you can give it an out variable to put the result into
                tier = int.TryParse(parts[4], out output) ? output : 0, //buh buh
                cost = int.TryParse(parts[5], out output) ? output : 0
            };
        }
        private ItemCard ConvertItemText(string line)
        {
            string[] parts = line.Split(","); // turns a string into array depending on the Split() parameters
            Debug.Log(parts.Length + "parts");
            return new ItemCard
            {
                name = parts[0],
                description = parts[1],
                tier = int.TryParse(parts[4], out int output) ? output : 0, //buh buh
                cost = int.TryParse(parts[5], out output) ? output : 0
            };
        }
        private MutationCard ConvertMutationText(string line)
        {
            string[] parts = line.Split(","); // turns a string into array depending on the Split() parameters
            Debug.Log(parts.Length + "parts");
            return new MutationCard
            {
                name = parts[0],
                description = parts[1],
            };
        }
    }
}



