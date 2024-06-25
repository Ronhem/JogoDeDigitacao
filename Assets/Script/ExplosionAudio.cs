using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionAudio : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;
    // Update is called once per frame
    public void playAudio()
    {
        source.PlayOneShot(clip);
    }
}
