using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowRoller : MonoBehaviour {
	Rigidbody physics;
	private Vector3 PlayerPosition; 
	public float force = 5.0f;
	Transform target;


	// Use this for initialization
	void Start () {
		physics = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	public void FollowMe (Transform target)
	{
		this.target = target;
	}

	public void StopFollowing ()
	{
		this.target = null;
	}

	void FixedUpdate()
	{
		if (target != null) {
			physics.AddForce ((target.position - transform.position).normalized * force);
		}
	}
}
