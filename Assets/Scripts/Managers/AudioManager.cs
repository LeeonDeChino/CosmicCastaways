using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    public AudioSource sourceAudio;
    public AudioClip Track4;
    public AudioClip laser_01;
    public AudioClip losegameover;
    public AudioClip DoorLock22;
    public AudioClip magic03;
    public AudioClip mosnterscream57;

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

    public void PlayLose()
    {
        sourceAudio.PlayOneShot(losegameover, 0.6f);
    }

    public void PlayJump()
    {
        sourceAudio.PlayOneShot(DoorLock22, 0.7f);
    }

    public void PlayMagic()
    {
        sourceAudio.PlayOneShot(magic03, 0.7f);
    }

    public void PlayMonster()
    {
        sourceAudio.PlayOneShot(mosnterscream57, 0.7f);
    }
}
