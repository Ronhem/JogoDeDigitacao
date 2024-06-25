using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject texto;
    public GameObject menu;
    public AudioSource source;
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

    public void PlayEffect()
    {
        source.Play();
    }

    public void Credits()
    {
        texto.SetActive(true);
        menu.SetActive(false);
    }

    public void Credits2()
    {
        texto.SetActive(false);
        menu.SetActive(true);
    }


    public void ReturnMainMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
