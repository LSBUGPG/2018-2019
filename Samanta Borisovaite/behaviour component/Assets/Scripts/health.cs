using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour {

	public int healthPoints;
	public Text healthText;

	// Use this for initialization
	void Start () {

		healthPoints = 3;
		SetHealthText ();

		
	}
	
	// Update is called once per frame
	void Update () {
		
		SetHealthText ();
		
	}

	void SetHealthText ()
	{
		healthText.text = "HP: " + healthPoints.ToString () +"/3";
	}

	private void OnCollisionEnter(Collision Collision)
	{
		

		if (Collision.collider.gameObject.tag == "Hazard") 
		{
			healthPoints = healthPoints - 1;
			transform.position = new Vector3 (0f, 1.49f, -15.3f);
		}
			
			
	}
}
