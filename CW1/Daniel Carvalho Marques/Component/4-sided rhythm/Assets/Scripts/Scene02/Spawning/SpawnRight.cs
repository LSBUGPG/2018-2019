﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRight : MonoBehaviour 
{
	public GameObject SpawnRightPrefab;
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
			Instantiate (SpawnRightPrefab, SQ.position, SQ.rotation);
		}
	}
}