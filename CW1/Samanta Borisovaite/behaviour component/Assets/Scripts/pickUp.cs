using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class pickUp : MonoBehaviour 
{
	public GameObject pickUptext;
	public Text countText;
	bool pickUpAllowed;

	public characterController charCon;

	void Start () 
	{
		pickUptext.SetActive (false);
		SetCountText ();	
	}

	void Update () 
	{
		if (pickUpAllowed && Input.GetKeyDown(KeyCode.E)) 
		{
			PickUp ();
		}	
	}


	private void OnTriggerEnter(Collider Collision)
	{
		if (Collision.gameObject.name.Equals("Character")) 
		{
			pickUptext.gameObject.SetActive (true);
			pickUpAllowed = true;
		}
	}

	private void OnTriggerExit (Collider collision)
	{
		if (collision.gameObject.name.Equals ("Character")) 
		{
			pickUptext.SetActive (false);
			pickUpAllowed = false;
		}
	}

	private void PickUp()
	{
		Destroy(gameObject);
		charCon.count += 1;
		SetCountText();
		pickUptext.SetActive(false);
	}

	void SetCountText ()
	{
		countText.text = "Collected: " + charCon.count.ToString ();
	}
}
