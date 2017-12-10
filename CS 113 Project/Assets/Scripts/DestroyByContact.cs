using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour {

	public GameController gameController;
    AudioSource audioSource;
    public AudioClip killSound;

	void Start()
	{
        audioSource = gameObject.GetComponent<AudioSource>();
        GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
		if (gameControllerObject != null) {
			gameController = gameControllerObject.GetComponent<GameController> ();
		} else {
			Debug.Log ("Cannot find 'GameController' object");
		}
	}

	void OnTriggerEnter(Collider other){
		if (other.CompareTag ("Player"))
        {
            audioSource.clip = killSound;
            audioSource.Play();
            Destroy(other.gameObject);
            gameController.GameOver();
        }
		if (other.CompareTag("Bullet")) {
			Destroy (other.gameObject);
			Destroy (gameObject);
		}
	}
}
