﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    SoundManager singleton;

    public List<AudioClip> footStepGround;
    public List<AudioClip> footStepWater;
    public List<AudioClip> footStepGrass;
    public List<AudioClip> footStepWood;
    public List<AudioClip> bladeWoosh;
    public List<AudioClip> blood;
    public List<AudioClip> deathYell;


    void Awake()
    {
        singleton = this;
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void PlayOneShot(AudioClip audioClip, float volume, AudioSource audioSource)
    {
            audioSource.PlayOneShot(audioClip, volume);
    }


}
