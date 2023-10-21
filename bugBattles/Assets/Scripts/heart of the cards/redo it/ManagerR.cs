using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerR : MonoBehaviour
{
    private static bool debugEnabled = true;
    [SerializeField] private bool debugLog = false;
    [SerializeField] private bool logToggle = false;

    void Start()
    {
        
    }

    void Update()
    {
        debugLog = debugEnabled;
        if (logToggle)
        {
            logToggle = false;

            if (debugEnabled)
            {
                debugEnabled = false;
            }
            else
            {
                debugEnabled = true;
            }
        }
    }

    public static void Log(object message)
    {
        if (debugEnabled)
        {
            Debug.Log(message);
        }
    }
}
