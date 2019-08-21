using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour 
{
	public Vector3 offsets;
	public Rigidbody projectile;
	public float fireRate = 0.1f;
	private float nextFire = 0.0f;
	// Use this for initialization
	void Start () 
	{
	}
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey("space") && Time.time > nextFire)
		{
			nextFire = Time.time + fireRate;
			Instantiate (projectile, transform.position + offsets, Quaternion.identity);
		}
	}
}
