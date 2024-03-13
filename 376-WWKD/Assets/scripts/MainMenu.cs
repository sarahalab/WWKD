using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu : MonoBehaviour
{
    public GameObject MainMenuUI;
    public GameObject optionMenuUI;
    public GameObject characterSelectUI;

    public void OptionsMenu()
    {
        MainMenuUI.SetActive(false);
        optionMenuUI.SetActive(true);
    }

    public void DisplayLevels()
    {
        characterSelectUI.SetActive(true);
        MainMenuUI.SetActive(false);

    }

    public void QuitGame()
    {
        Application.Quit();
    }


}
