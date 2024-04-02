using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FishCollector : MonoBehaviour
{
    private float score = 0;
    private bool startScoreCounter = false;

    [SerializeField] private Text kibbleScore;

    private void Start()
    {
        if (kibbleScore == null)
        {
            Debug.LogError("KibbleScore Text component is not assigned in the Inspector.", this);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Kibble"))
        {
            if (kibbleScore != null)
            {
                Destroy(collision.gameObject);
                score += 1000;
                kibbleScore.text = "Score: " + score;
            }
            else
            {
                Debug.LogError("Trying to update score, but kibbleScore is null.", this);
            }
        }

        if (collision.gameObject.CompareTag("FinishLine"))
        {
            startScoreCounter = false;
        }
    }
}
