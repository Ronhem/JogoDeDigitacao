using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordColision : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public WordManager wordManager_;
    public AudioSource oops;
    public bool colisionW;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(playerHealth.Health == 0)
        {
            Debug.Log("GameOver!");
        }
        else
        {
            colisionW = true;
            wordManager_.hasActiveWord = false;
            playerHealth.Health--;
            Debug.Log("Collision!" + playerHealth.Health);
            oops.Play();
        }
    }
    private void Update()
    {

    }
}
