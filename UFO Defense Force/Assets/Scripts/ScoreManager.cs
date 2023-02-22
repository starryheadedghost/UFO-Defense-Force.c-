using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    public int score; //store score value
    public TextMeshProUGUI scoreText; //reference visual text ui element to change

    //this rewards the player
    public void IncreaseScore(int amount)
    {
        score += amount; //add amount to score
        UpdateScoreText(); //update the score ui text
    }

    public void DecreaseScore(int amount)
    {
        score -= amount; //subtract amount from the score
        UpdateScoreText(); //update the score ui text
    }

    public void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }

}
