using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

	void OnCollisionEnter(Collision collision){

		if (collision.collider.CompareTag ("Player")) {
			Destroy (collision.collider.gameObject);
			Destroy (gameObject);
		}
	}

}
