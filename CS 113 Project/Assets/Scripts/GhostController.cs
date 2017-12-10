using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostController : MonoBehaviour {

	public float speed;
	private GameObject player;

	private float nextImage = 0;
	private float walkRate = 0.1f;
	private bool right = true;

	void Start () {
		player = GameObject.FindWithTag ("Player");
	}

	void Update () {
		if (player != null) {
			transform.LookAt (player.transform);
			transform.position += transform.forward * speed * Time.deltaTime;
		}
		if (Time.time > nextImage)
		{
			nextImage = walkRate + Time.time;
			gameObject.transform.Find ("Left").gameObject.SetActive(right);
			gameObject.transform.Find ("Right").gameObject.SetActive(!right);
			right = !right;

		}
	}
}
