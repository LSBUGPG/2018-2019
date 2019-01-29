using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCubes : MonoBehaviour {

	public GameObject CubesSpawn;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update ()
	{

		if (Input.GetKeyDown (KeyCode.Space)) {
			Instantiate (CubesSpawn, new Vector3 (Random.Range (-7f, 7f), 15f, 0), Quaternion.identity); //Quaternion.identity = do not rotate - to spawn beach ball
		}


	}
}