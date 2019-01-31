﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraLook : MonoBehaviour {
    public float camrot = 100.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float rotation = Input.GetAxis("Mouse Y") * camrot * -1;
        rotation *= Time.deltaTime;
        transform.Rotate(rotation, 0, 0);
    }
}
