using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Playershield : MonoBehaviour 
{
	public GameObject Shield;
	float currentShieldLevel = 0;
	float maxShieldLevel = 150;
	bool shieldRecover = true; 
	// Use this for initialization
	void Start () 
	{
		currentShieldLevel = maxShieldLevel;

	}
	// Update is called once per frame
	void Update () 
	{
		if (shieldRecover == true && currentShieldLevel <= 149 ) 
		{
			if (Time.timeScale == 1) 
			{
				currentShieldLevel += 1; 
			}
		}
		if (Input.GetKey ("left shift") && currentShieldLevel >= 0 ) 
		{
			shieldRecover = false;
			currentShieldLevel -= 3; 
			Shield.SetActive (true);
		}

		if (Input.GetKeyUp ("left shift")) 
		{
			shieldRecover = true;
			Shield.SetActive (false);
		}
	
		if (currentShieldLevel <= 0) 
		{
			Shield.SetActive (false);
		}
	}

}