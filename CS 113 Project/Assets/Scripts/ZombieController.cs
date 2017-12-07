using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieController : MonoBehaviour {
	public Transform thisObject;
	public Transform target;
	private UnityEngine.AI.NavMeshAgent navComponent;

	private float nextImage = 0;
	private float walkRate = 0.3f;
	private bool right = true;

	void Start()
	{
		GameObject targetObject = GameObject.FindGameObjectWithTag ("Player");
		if(targetObject != null)
			target = targetObject.transform;
		navComponent = this.gameObject.GetComponent<UnityEngine.AI.NavMeshAgent> ();
	}
	void Update(){
		//float dist = Vector3.Distance (target.position, transform.position);
		if (target != null) {
			navComponent.SetDestination (target.position);
		} 
		if (Time.time > nextImage)
		{
			nextImage = walkRate + Time.time;
			gameObject.transform.Find ("Left").gameObject.SetActive(right);
			gameObject.transform.Find ("Right").gameObject.SetActive(!right);
			right = !right;

		}
		/*
		else {
			if (target == null)
				target = this.gameObject.GetComponent<Transform> ();
			else
				target = GameObject.FindGameObjectWithTag ("Player").transform;
		}*/
	}

}
