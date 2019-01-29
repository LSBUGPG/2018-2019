using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectile : MonoBehaviour 
{

	public Rigidbody rb;
	public float fowardForce = 3000f;


	// Use this for initialization
	void Start () 
	{
		Destroy(gameObject, 1);
	}

	void OnCollisionEnter(UnityEngine.Collision collisionInfo)
	{
		if (collisionInfo.gameObject.tag == "EnemyProjectile") 
		{
			Destroy (gameObject);
		}

		if (collisionInfo.gameObject.tag == "Enemy") 
		{
			Destroy (gameObject);
		}

		if (collisionInfo.gameObject.tag == "Barrier") 
		{
			Destroy (gameObject);
		}
	
		if (collisionInfo.gameObject.tag == "EnemyBullet") 
		{
			Destroy (gameObject);
		}

		if (collisionInfo.gameObject.tag == "Collectable") 
		{
			Destroy (gameObject);
		}
	
		if (collisionInfo.gameObject.tag == "BossHomingBullet") 
		{
			Destroy (gameObject);
		}

		if (collisionInfo.gameObject.tag == "BossHead") 
		{
			Destroy (gameObject);
		}

		if (collisionInfo.gameObject.tag == "BossLaser") 
		{
			Destroy (gameObject);
		}
	
	}


	void Update ()
	{
		//Foward momentum
		rb.AddForce (0, 0, fowardForce * Time.deltaTime, ForceMode.VelocityChange);

		// stops the velocity (So that the character stops moving once key has stopped being pressed).
		rb.velocity = Vector3.zero;
	}
}
