using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostController : MonoBehaviour {

	public float speed;
	private GameObject player;
	void Start () {
		player = GameObject.FindWithTag ("Player");
	}

	void Update () {
		if (player != null) {
			transform.LookAt (player.transform);
			transform.position += transform.forward * speed * Time.deltaTime;
		}
	}
}
