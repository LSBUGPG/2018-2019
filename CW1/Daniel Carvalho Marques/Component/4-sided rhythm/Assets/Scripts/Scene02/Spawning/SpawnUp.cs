using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnUp : MonoBehaviour 
{
	public GameObject SpawnUpPrefab;
	public Transform SQ;

	// Use this for initialization
	void Start () 
	{

	}

	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown ("r")) 
		{
			Instantiate (SpawnUpPrefab, SQ.position, SQ.rotation);
		}
	}
}
