using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDown : MonoBehaviour 
{
	public GameObject SpawnDownPrefab;
	public Transform SQ;

	// Use this for initialization
	void Start () 
	{

	}

	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown ("w")) 
		{
			Instantiate (SpawnDownPrefab, SQ.position, SQ.rotation);
		}
	}
}
//if (Input.GetKeyDown (KeyCode.Space)) {
//	Instantiate (ball, new Vector3 (Random.Range (-7f, 7f), 6f, 0), Quaternion.identity);