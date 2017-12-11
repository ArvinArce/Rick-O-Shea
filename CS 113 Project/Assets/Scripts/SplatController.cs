using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplatController : MonoBehaviour {

	public float lifeTime;
	// Use this for initialization
	void Start () {
		StartCoroutine (Despawn ());
	}

	IEnumerator Despawn ()
	{
		yield return new WaitForSeconds (lifeTime);
		Destroy (gameObject);

	}
}
