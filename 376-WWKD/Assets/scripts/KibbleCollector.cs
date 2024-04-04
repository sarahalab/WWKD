using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KibbleCollector : MonoBehaviour
{
    private float score = 0;
    //private bool startScoreCounter = false;

    [SerializeField] private Text kibbleScore;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Kibble"))
        {
            Destroy(collision.gameObject);
            score += 1;
            kibbleScore.text = "Kibble: " + score;
        }

        /*if (collision.gameObject.CompareTag("FinishLine"))
        {
            startScoreCounter = false;
        }*/
    }
}
