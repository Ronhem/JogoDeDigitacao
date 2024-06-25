using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    public TextMeshProUGUI scoreText1;
    public WordManager scoreValue;
    public GameObject wordPrefab;

    public void scoreText()
    {
        scoreText1.text = $"{scoreValue.GetScore()}";
    }

    private void Update()
    {
        scoreText();
    }
}
