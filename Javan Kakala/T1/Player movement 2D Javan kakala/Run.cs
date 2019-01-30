using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : MonoBehaviour {

    Rigidbody2D rb;
    float movespeed = 5f;
    float dirX;

	// Use this for initialization
	void Start () {
		rb = GetComponent < Rigidbody2D > ();
	}

    // Update is called once per frame
   void Update() {

        if (Input.GetKey(KeyCode.LeftShift))
            movespeed = 10f;
        else
            movespeed = 5f;
        dirX = Input.GetAxis("Horizontal") * movespeed;
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX, rb.velocity.y);
    }
}

