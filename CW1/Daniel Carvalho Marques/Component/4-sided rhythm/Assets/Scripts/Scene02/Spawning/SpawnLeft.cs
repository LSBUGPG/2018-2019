using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLeft : MonoBehaviour 
{
	public GameObject SpawnLeftPrefab;
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
			Instantiate (SpawnLeftPrefab, SQ.position, SQ.rotation);
		}
	}
}
