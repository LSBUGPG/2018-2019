using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteObject : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		Destroy(gameObject, 2); //don't put this line in SpawnCube script or whole scene changes colour
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
