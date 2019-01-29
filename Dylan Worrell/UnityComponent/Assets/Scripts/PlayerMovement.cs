using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour 
{
	public Rigidbody rb;
	public float force = 500f;
	// Use this for initialization
	void Start () 
	{

	}
	// Update is called once per frame
	void FixedUpdate () 
	{
			// stops Players velocity (So that the character stops moving once key has stopped being pressed).
		rb.velocity = Vector3.zero;

		// PLAYER Movement
		if (Input.GetKey ("s")) {
			rb.AddForce (0, 0 , -force * Time.deltaTime, ForceMode.VelocityChange);
		}
		if (Input.GetKey ("w")) {
			rb.AddForce (0, 0, force * Time.deltaTime, ForceMode.VelocityChange);
		}
		if (Input.GetKey ("d")) {
			rb.AddForce (force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}
		if (Input.GetKey ("a")) {
			rb.AddForce (-force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}
	}
}