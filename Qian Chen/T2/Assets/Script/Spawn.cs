using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

	public GameObject spawnObject;
	public float jumpForce;

	Rigidbody rb;

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
			GameObject temp = Instantiate (spawnObject, transform.position, Quaternion.identity);

			rb = temp.GetComponent<Rigidbody>();
			rb.velocity = new Vector3 (rb.velocity.y, jumpForce, rb.velocity.z);
		}
	}
}
