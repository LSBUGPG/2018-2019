using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour {

	public Transform spawnPosition;
	public GameObject spawnObject;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButton(0)) {
			Instantiate (spawnObject, spawnPosition.position, spawnPosition.rotation);
		}

	}
}
