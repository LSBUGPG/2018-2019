using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    bool onGround = true; 
    bool canDoubleJump = false; 


    void Update()
    {
        RaycastHit hit;
        Vector3 physicsCentre = this.transform.position +
            this.GetComponent<CapsuleCollider>().center; 

        Debug.DrawRay(physicsCentre, Vector3.down * 1.3f, Color.red, 1); 
        if (Physics.Raycast(physicsCentre, Vector3.down, out hit, 1.3f)) 
        {
            if (hit.transform.gameObject.tag != "Player") 
            {
                onGround = true; 
            }
        }
        else
        {
            onGround = false; 
        }
        Debug.Log(onGround);


        if (Input.GetKeyDown("space") && !onGround && canDoubleJump)
        {
            this.GetComponent<Rigidbody>().AddForce(Vector3.up * 250);
            canDoubleJump = false; 
        }
        else if (Input.GetKeyDown("space") && onGround)
        {
            this.GetComponent<Rigidbody>().AddForce(Vector3.up * 250);
            canDoubleJump = true; 
        }
    }
}
