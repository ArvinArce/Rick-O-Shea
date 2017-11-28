using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieController : MonoBehaviour {
	public Transform thisObject;
	public Transform target;
	private UnityEngine.AI.NavMeshAgent navComponent;

	void Start()
	{
		target = GameObject.FindGameObjectWithTag ("Player").transform;
		navComponent = this.gameObject.GetComponent<UnityEngine.AI.NavMeshAgent> ();
	}
	void Update(){
		//float dist = Vector3.Distance (target.position, transform.position);
		if (target != null) {
			navComponent.SetDestination (target.position);
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
