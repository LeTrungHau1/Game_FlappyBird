using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sourceCtroller : MonoBehaviour
{
    public static sourceCtroller instance;
    private void Awake()
    {
        instance = this;
    }
    public void PlaythisSource(string clipName, float volumeMutipller)
    {
        AudioSource audiosource = this.gameObject.AddComponent<AudioSource>();
        audiosource.volume *= volumeMutipller;
        audiosource.PlayOneShot((AudioClip)Resources.Load("Sounds/" + clipName, typeof(AudioClip)));
    
    }
}
