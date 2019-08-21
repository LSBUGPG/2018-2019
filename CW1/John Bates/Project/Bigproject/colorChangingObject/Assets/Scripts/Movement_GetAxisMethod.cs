using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Movement_GetAxisMethod : MonoBehaviour {

    float speed = 50f;
	
	// Update is called once per frame
	void Update () {

        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * speed, 0, Input.GetAxis("Vertical") * Time.deltaTime * speed);
	}
}

