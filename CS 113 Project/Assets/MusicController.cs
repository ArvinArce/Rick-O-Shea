using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour {

	AudioSource audioSource;
	public AudioClip musicLoop;

	void Start () {
		StartCoroutine (StartLoop ());
	}

	IEnumerator StartLoop ()
	{
		yield return new WaitForSeconds (30);
		audioSource.clip = musicLoop;
		audioSource.Play();

	}
}
