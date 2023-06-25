using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtonManager : MonoBehaviour
{
    public GameObject Credits;
    public GameObject MainMenu;
    public GameObject ModeSelect;

    //after a new function is made you can then put the gameobject with the script as a function for the button where you can then select one of the functions
    //in the code for the button to press, make sure to put this code as parent to the buttons and as a child to a UI canvas
    public void StartButton(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
        Debug.Log("scene changed");
    }

    public void CreditsButton()
    {
        Credits.SetActive(true);
        MainMenu.SetActive(false);
        Debug.Log("credits");
    }

    public void CreditsBackButton()
    {
        Credits.SetActive(false);
        MainMenu.SetActive(true);
        Debug.Log("credits back");
    }

    public void ModeSelectButton()
    {
        ModeSelect.SetActive(true);
        MainMenu.SetActive(false);
        Debug.Log("ModeSelect");
    }

    public void ModeSelectBackButton()
    {
        ModeSelect.SetActive(false);
        MainMenu.SetActive(true);
        Debug.Log("ModeSelect back");
    }

    public void QuitButton()
    {
        Application.Quit();
        Debug.Log("Quit the game");
    }
}
