using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class listTest : MonoBehaviour
{
    GameObject gameobject;
    [SerializeField] List<GameObject> gameObjectList;
    [SerializeField] bool spawnNew = false;
    [SerializeField] bool removeOne = false;
    [SerializeField] int listIndexToRemove;
    private void Start()
    {

        gameobject = new GameObject();
        gameObjectList.Add(gameobject);
    }
    void Update()
    {
        if (spawnNew)
        {
            spawnNew = false;
            gameobject = Instantiate(gameobject);
            gameObjectList.Add(gameobject);
        }
        if (removeOne)
        {
            removeOne = false;
            gameobject = gameObjectList[listIndexToRemove];
            gameObjectList.RemoveAt(listIndexToRemove);
            Destroy(gameobject);
        }
    }
}
