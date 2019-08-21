using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float fowardForce = 900f; //Adding a moving Foward force
    public float horizontalForce = 500f; //Adding a moving side force


    void FixedUpdate()
    {



        rb.velocity = Vector3.zero;



        if (Input.GetKey("a"))
        {
            rb.AddForce(horizontalForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); //When press "a" moving left
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(-horizontalForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); //When press "d" moving right
        }

        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, fowardForce * Time.deltaTime, ForceMode.VelocityChange); //When press "w" moving foward
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -fowardForce * Time.deltaTime, ForceMode.VelocityChange); //When press "s" moving back
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up")) //naming the tag of the object that we want the Player to collect
        {
            other.gameObject.SetActive(false); //when collide setting it to de-active
        }

    }
}