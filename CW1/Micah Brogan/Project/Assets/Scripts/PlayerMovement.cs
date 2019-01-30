﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public bool canMove;

	// Use this for initialization
	void Start ()
	{
		canMove = true;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (canMove) 
		{
			var x = Input.GetAxis ("Horizontal") * Time.deltaTime * 150.0f;
			var z = Input.GetAxis ("Vertical") * Time.deltaTime * 3.0f;

			transform.Rotate (0, x, 0);
			transform.Translate (0, 0, z);
		}
	}
}
