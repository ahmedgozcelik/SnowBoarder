using System.Collections;
using System.Collections.Generic;
using UnityEditor.iOS;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    [SerializeField] Text scoreText;
    int totalScore = 0;

    private void Start()
    {
        scoreText.text = "Score: " + totalScore;
    }

    public void IncreaseScore(int amount)
    {
        totalScore += amount;
    }

    public void UpdateScoreText()
    {
        scoreText.text = "Score: " + totalScore;
    }
}
