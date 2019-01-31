using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour {

	public float speed = 5.0F;

	//public LayerMask groundLayers;
	[Header("Ground Variables")]
	public float jumpForce = 6.0F;
	public CapsuleCollider col;
	public bool grounded;

	public int count = 0;

	Rigidbody rb;




	// Use this for initialization
	void Start () 
	{

		Cursor.lockState = CursorLockMode.Locked;

		rb = GetComponent<Rigidbody> ();
		col = GetComponent<CapsuleCollider> ();
	
	}
	
	// Update is called once per frame
	void Update () {

		float translation = Input.GetAxis ("Vertical") * speed;
		float straffe = Input.GetAxis ("Horizontal") * speed;
		translation *= Time.deltaTime;
		straffe *= Time.deltaTime;

		transform.Translate (straffe, 0, translation);
		if (Input.GetKeyDown("escape")) {
			Cursor.lockState = CursorLockMode.None;
		}

		if (grounded == true && Input.GetKeyDown(KeyCode.Space))
		{
			rb.AddForce (Vector3.up * jumpForce, ForceMode.Impulse);
		}
		else if (grounded == false && Input.GetKeyDown(KeyCode.Space))
		{
			return;
			
		}
			
	}

	void OnCollisionEnter (Collision collision){
		if (collision.gameObject.CompareTag ("Ground")) {
			grounded = true;
		}
	}
		void OnCollisionExit (Collision collision){
		if (collision.gameObject.CompareTag("Ground")) {
				grounded = false;
			}
}
}
