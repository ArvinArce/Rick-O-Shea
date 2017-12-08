using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour {

	public GameController gameController;

	void Start()
	{
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
			gameObject.GetComponent<AudioSource>().Play()
            gameController.GameOver();
        }
		if (other.CompareTag ("Player") || other.CompareTag("Bullet")) {
			Destroy (other.gameObject);
			Destroy (gameObject);
		}
	}
}
