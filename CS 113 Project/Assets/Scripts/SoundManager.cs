using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {
    private static int NUM_SOUNDS = 8;
    public AudioClip[] sounds = new AudioClip[NUM_SOUNDS];
    AudioSource audioSource;
    
	// Use this for initialization
	void Start () {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.clip = sounds[Random.Range(0, NUM_SOUNDS)];
        audioSource.Play();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
