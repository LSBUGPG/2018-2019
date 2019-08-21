using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableObjectSelect : MonoBehaviour
{
	bool inRange;
	public float rotSpeed;
	bool played;

	float panX, panY;
	Vector3 baseRot;

	public Camera evidenceCam;
	public AudioSource audioSource;
	Camera playerCam;

	// Use this for initialization
	void Start ()
	{

		playerCam = GameObject.FindGameObjectWithTag ("playerCam").GetComponent<Camera> ();
		evidenceCam.enabled = false;

		baseRot = transform.eulerAngles;

		panX = transform.eulerAngles.y;
		panY = transform.eulerAngles.x;

		played = false;
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
		if (inRange && Input.GetKeyDown (KeyCode.KeypadEnter)) {
			print ("Interacting With Things");
		}

		if (inRange) {

			if (Input.GetKey (KeyCode.Space)) 
			{
				evidenceCam.enabled = true;
				playerCam.enabled = false;

				if (gameObject.tag == "evidence") {
					
					transform.eulerAngles = new Vector3 (panY, panX, 0);

					float rotX = Input.GetAxis ("Mouse X");
					float rotY = Input.GetAxis ("Mouse Y");

					panX += rotX * rotSpeed;
					panY -= rotY * rotSpeed;

				} else {
					if (gameObject.tag == "corpse" && played == false) {
						audioSource.Play ();
						played = true;
					}

				}

			} else {
				playerCam.enabled = true;
				evidenceCam.enabled = false;

				if (gameObject.tag == "evidence") {

					transform.eulerAngles = baseRot;

					panX = transform.eulerAngles.y;
					panY = transform.eulerAngles.x;
				}
			}

		} else {
			if (evidenceCam.enabled) {
				
				playerCam.enabled = true;
				evidenceCam.enabled = false;

				if (gameObject.tag == "evidence") {

					transform.eulerAngles = baseRot;

					panX = transform.eulerAngles.y;
					panY = transform.eulerAngles.x;
				}
			}
		}
	}

	void OnTriggerStay (Collider other)
	{

		if (other.gameObject.tag == "Player") {
			inRange = true;
		}
	}

	void OnTriggerExit (Collider other)
	{
		print ("Leave");
		inRange = false;
		played = false;
	}
}