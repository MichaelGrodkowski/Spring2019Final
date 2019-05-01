using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigSFX : MonoBehaviour
{
    public AudioClip SoundToPlay;
    public float Volume;
    AudioSource audio;
    public bool AlreadyPlayed = false;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    
    void OnTriggerEnter()
    {
        if (!AlreadyPlayed)
        {
            audio.PlayOneShot(SoundToPlay, Volume);
            AlreadyPlayed = true;
        }
    }
}
