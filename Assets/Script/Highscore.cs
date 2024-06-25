using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Highscore : MonoBehaviour
{
    public TextMeshProUGUI highscoreT;
    public WordManager scoreget;

    public void CheckHighScore()
    {
        if(scoreget.GetScore() > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", scoreget.GetScore());
        }
    }

    public void ScoreTextUpdate()
    {
        highscoreT.text = $"Pontuação máxima: {PlayerPrefs.GetInt("HighScore", 0)}";
    }

    private void Update()
    {
        ScoreTextUpdate();
    }
}
