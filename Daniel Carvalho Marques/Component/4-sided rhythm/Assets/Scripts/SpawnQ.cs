﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnQ : MonoBehaviour 
{
	public GameObject CubesSpawn;
	public Transform SQ;

	// Use this for initialization
	void Start () 
	{
		
	}

	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown ("q")) 
		{
			Instantiate (CubesSpawn, SQ.position, SQ.rotation);
		}
	}
}
