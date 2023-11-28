using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    public AudioSource sourceAudio;
    public AudioClip Track4;
    public AudioClip laser_01;

    private void Awake()
    {
        instance = this;
    }

    // crea diferentes funciones para reproducir y controlar el volumen 

    public void StartMusic()
    {
       sourceAudio.PlayOneShot(Track4,0.3f);
    }

    public void PlayLaser()
    {
        sourceAudio.PlayOneShot(laser_01, 0.7f);
    }
}
