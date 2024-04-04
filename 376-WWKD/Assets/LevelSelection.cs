using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelection : MonoBehaviour
{
    public GameObject MainMenuUI;
    public GameObject characterSelectUI;

    public void startDogLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        Time.timeScale = 1.0f;
        PauseMenu.GameIsPaused = false;
    }
    public void startCatLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1.0f;
        PauseMenu.GameIsPaused = false;
    }

    public void returnMenus()
    {
        MainMenuUI.SetActive(true);
        characterSelectUI.SetActive(false);
    }
}
