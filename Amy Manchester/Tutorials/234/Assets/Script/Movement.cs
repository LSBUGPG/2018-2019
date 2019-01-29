using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

public float moveSpeed = 3f; //this is the speed in which the cube will travel

    void Start()
    {

    }


    void Update()
    {                        //this allows the cube to move up and down
        transform.Translate(Vector3.forward * Time.deltaTime * Input.GetAxis("Vertical") * moveSpeed);

        //this allows the cube to let and right
        transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal") * moveSpeed);
    }
}

