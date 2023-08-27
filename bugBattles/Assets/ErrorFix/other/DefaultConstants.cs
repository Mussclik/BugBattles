using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace ErrorCatch
{
    public class DefaultConstants : MonoBehaviour
    {
        public string tag;
        bool tagCorrect = false;
        public static Material material;
        public static Sprite sprite;
        public static GameObject gameobject;
        public Material errorMaterial;
        public Sprite errorSprite;
        public GameObject errorGameobject;

        private void Awake()
        {
            material = errorMaterial;
            sprite = errorSprite;
            gameobject = errorGameobject;
        }

        private bool TagCheck()
        {
            if (tag == null)
            {
                Debug.LogError("ERROR CATCH TAG NOT SET");
                return false;
            }
            else if (tag.ToLower() != gameobject.tag.ToLower())
            {
                Debug.LogError("ERROR CATCH TAG DOESNT MATCH");
                return false;
            }
            else if (tag.ToLower() == gameobject.tag.ToLower())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Material MatCatch(Material input)
        {

            if (!TagCheck())
            {
                return material;
            }

            try
            {
                if (input == null)
                {
                    return material;
                }
                else
                {
                    return input;
                }
            }
            catch
            {
                return material;
            }
        }

        public GameObject GBCatch(GameObject input)
        {

            if (!TagCheck())
            {
                return gameobject;
            }

            try
            {
                if (input == null)
                {
                    return gameobject;
                }
                else
                {
                    return input;
                }
            }
            catch
            {
                return gameobject;
            }
        }

        public Sprite SpriteCatch(Sprite input)
        {

            if (!TagCheck())
            {
                return sprite;
            }

            try
            {
                if (input == null)
                {
                    return sprite;
                }
                else
                {
                    return input;
                }
            }
            catch
            {
                return sprite;
            }
        }
    }
}

