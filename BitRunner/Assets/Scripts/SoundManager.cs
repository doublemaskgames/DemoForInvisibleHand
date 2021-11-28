using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public AudioClip slash;
    public AudioClip hit;
    public AudioClip jump;
    public AudioClip coin;
    public AudioClip shoot;

    AudioSource audioSource;

    private void Start() {
    audioSource = GetComponent<AudioSource>();    
    }

    public void PlaySound(AudioClip clip){
        audioSource.PlayOneShot(clip, 1f);
    }


    public void ChangeBGM(AudioClip bgm){
        audioSource.clip = bgm;
        audioSource.Play();
    }

}
