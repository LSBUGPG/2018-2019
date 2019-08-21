using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowNonRoller : MonoBehaviour {

	private Vector3 PlayerPosition; 
	public float force = 5.0f;
	Transform target;


	// Use this for initialization
	void Start () {
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
			transform.position = Vector3.MoveTowards(transform.position, target.position, force *Time.deltaTime);
		}
	}
}
