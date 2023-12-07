using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLink : MonoBehaviour
{
    public string normal, shift, ctrl, alt;
    public void OpenHyperLink()
    {
        if (Input.GetKey(KeyCode.LeftShift) && shift != null && shift != "")
        {
            Application.OpenURL(shift);
        }
        else if (Input.GetKey(KeyCode.LeftControl) && ctrl != null && ctrl != "")
        {
            Application.OpenURL(ctrl);
        }
        else if (Input.GetKey(KeyCode.LeftAlt) && alt != null && alt != "")
        {
            Application.OpenURL(alt);
        }
        else
        {
            //basic with no special inputs
            Application.OpenURL(normal);
        }
    }
}
