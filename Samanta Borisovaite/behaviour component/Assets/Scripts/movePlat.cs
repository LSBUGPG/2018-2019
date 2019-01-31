using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlat : MonoBehaviour {

	public GameObject pickUptext;
	public GameObject platform;
	public bool moveAllowed = false;
	public bool pressButtonAllowed = false;
	public Vector3 platfromPosition;


	// Use this for initialization
	void Start () 
	{
		pickUptext.SetActive (false);

	}

	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.E) && pressButtonAllowed == true) {
			moveAllowed = true;
			pickUptext.SetActive (false);
		}
		if (moveAllowed == true)
		{
			platform.transform.Translate(Vector3.left * Time.deltaTime);
		}

		if (platform.transform.position.x < 11.5)
		{
			moveAllowed = false;
		}
	}

	private void OnTriggerEnter(Collider Collision)
	{
		if (Collision.gameObject.name.Equals("Character")) 
		{
			pickUptext.gameObject.SetActive (true);
			pressButtonAllowed = true;

		}
	}

	private void OnTriggerExit (Collider collision)
	{
		if (collision.gameObject.name.Equals ("Character")) 
		{
			pickUptext.SetActive (false);
			pressButtonAllowed = false;
		}
	}
}
