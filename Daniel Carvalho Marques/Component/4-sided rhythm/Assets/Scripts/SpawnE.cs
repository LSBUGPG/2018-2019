using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnE : MonoBehaviour 
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
		if (Input.GetKeyDown ("e")) 
		{
			Instantiate (CubesSpawn, SQ.position, SQ.rotation);
		}
	}
}
