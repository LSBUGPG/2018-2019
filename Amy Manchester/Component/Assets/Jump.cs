using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{


    public Rigidbody rb;
    private bool onGround;
    void Start()
    {
        onGround = true;
        rb = GetComponent<Rigidbody>();

    }
    void Update()
    {
        if (onGround)
        {
            if (Input.GetButtonDown("Jump"))
            {
                rb.velocity = new Vector3(0f, 15f, 0f);
                onGround = false;
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            onGround = true;
        }
    }
}
