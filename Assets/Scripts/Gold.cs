using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : MonoBehaviour
{
    public int goldScore = 10;
    ScoreController scoreController;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            scoreController = collision.GetComponent<ScoreController>();
            scoreController.IncreaseScore(goldScore);
            scoreController.UpdateScoreText();
            Destroy(gameObject);
        }
    }
}
