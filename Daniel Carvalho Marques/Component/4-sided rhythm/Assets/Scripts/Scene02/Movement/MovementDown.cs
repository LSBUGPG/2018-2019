using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementDown : MonoBehaviour {

	public float movementSpeed = 10;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		transform.Translate (Vector3.down * movementSpeed * Time.deltaTime);
	}
}
