using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)) // This if statement states that when the left arrow is pressed, the cube will rotate on the axis 0,5,0
			transform.Rotate (0, 5, 0);
	}
}

