using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{

    public GameManager gameManager;
    public PlayerController playerController;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

            playerController.CanControl = false;

            gameManager.CompleteLevel();
        }

    }

}
