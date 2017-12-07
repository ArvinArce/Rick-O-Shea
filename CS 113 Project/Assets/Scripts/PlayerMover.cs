using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
	public float xMin, xMax, zMin, zMax;
}
	
public class PlayerMover : MonoBehaviour {
	
	private Rigidbody rb;
	public Boundary boundary;

	public float speed;
	private bool gameOver = false;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}
	void FixedUpdate(){


		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.velocity = movement * speed;

		rb.position = new Vector3(Mathf.Clamp(rb.position.x, boundary.xMin, boundary.xMax),
			0.0f,
			Mathf.Clamp(rb.position.z, boundary.zMin, boundary.zMax));
	}

}
