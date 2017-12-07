using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

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

	void OnCollisionEnter(Collision collision){

		if (collision.collider.CompareTag ("Player")) {
			Destroy (collision.collider.gameObject);
			Destroy (gameObject);
			gameController.GameOver ();
		}

	}

}
