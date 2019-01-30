using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float force = 100f; //Adding a float value of force to the Sphere to move top to bottom, repeat


    void Start()
    {
        rb.AddForce(0, -force, 0, ForceMode.Impulse); //Apply the impulse force instantly with a single function call. ... 
                                                      //This mode is useful for applying forces that happen instantly, such as forces from explosions or collisions. 
                                                      //In this mode, the unit of the force parameter is applied to the rigidbody as mass*distance/time
    }



    void OnCollisionEnter(UnityEngine.Collision collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "UpLimit") //Adding a top object that the Sphere will move to top
        {

            rb.AddForce(0, -force, 0, ForceMode.Impulse);
        }

        if (collisionInfo.gameObject.tag == "DownLimit") //Adding a bottom object that the Sphere will move to bottom
        {

            rb.AddForce(0, force, 0, ForceMode.Impulse);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) //naming the tag of the object that we want the Player to collect
        {
            other.gameObject.SetActive(false); //when collide setting it to de-active
        }

    }


}
