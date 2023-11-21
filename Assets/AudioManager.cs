using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    public AudioSource audioSource;
    public AudioClip[] clips;

    private void Awake()
    {
        instance = this;
    }

    public void PlaySound(int clip)
    {
        audioSource.PlayOneShot(clips[clip]);
    }
    public void StopSound(int clip)
    {
           audioSource.Stop();
    }
}
