using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    [SerializeField]private bool isPaused;
    public GameObject pauseMenu;
    public PlayerHealth gameOverCheck;

    public bool GetisPaused()
    {
        return isPaused;
    }

    public void PauseCheck()
    {
        if(gameOverCheck.isGameOver == true)
        {
            Debug.Log("GameOver");
        }
        else
        {
            if (isPaused == true)
            {
                Time.timeScale = 1;
                pauseMenu.SetActive(false);
                isPaused = false;
            }
            else
            {
                Time.timeScale = 0;
                pauseMenu.SetActive(true);
                isPaused = true;
            }
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseCheck();
        }
    }
}
