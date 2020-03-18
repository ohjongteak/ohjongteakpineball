using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgmScripts : MonoBehaviour
{
    AudioSource bgmsorceA;
    public AudioClip[] Clipsbgm;


    // Start is called before the first frame update
    void Start()
    {
        bgmsorceA = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    public void PlaybgmA()
    {
        bgmsorceA.clip = Clipsbgm[0];
        bgmsorceA.Play();
    }

    public void PlaybgmB()
    {
        bgmsorceA.clip = Clipsbgm[1];
        bgmsorceA.Play();
    }

    public void dontPlay()
    {
        bgmsorceA.Stop();
    }

    public void SetMusicVolume(float volume)
    {
        bgmsorceA.volume = volume;
    }

}

