using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SoundManager : MonoBehaviour {

    AudioSource AudioSource;

    void Awake()
    {
        AudioSource = GetComponent<AudioSource>();
    }

    public void Play(AudioClip clip)
    {
        AudioSource.clip = clip;
        AudioSource.Play();

    }

    void Start()
    {

    }
    void Update()
    {

    }

}
