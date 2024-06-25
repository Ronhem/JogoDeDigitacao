using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public int Health = 5;
    public Text gameOver;
    public WordInput GameInput;
    public GameObject menu;
    public GameObject pauseButton;
    public bool isGameOver = false;

    public int GetHealth()
    {
        return Health;
    }

    void Update()
    {
        if (Health <= 0)
        {
            isGameOver = true;
            pauseButton.SetActive(false);
            menu.SetActive(true);
            gameOver.enabled = true;
            GameInput.enabled = false;
        }
    }
}
