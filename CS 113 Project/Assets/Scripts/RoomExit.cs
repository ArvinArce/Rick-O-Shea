using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoomExit : MonoBehaviour {

	public int nextSceneIndex;

	// Use this for initialization
	void Start () {
		//play open door sound
	}
	
	void OnTriggerEnter(Collider other){

		if (other.CompareTag ("Player")) {
			SceneManager.LoadScene (nextSceneIndex);
		}
	}
}
