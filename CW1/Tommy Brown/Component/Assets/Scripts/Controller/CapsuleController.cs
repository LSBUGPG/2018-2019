using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleController : MonoBehaviour
{

    public float speed = 10f;
    public float sidespeed = 10f;
    public float rotationSpeed = 100f;
    public float GroundCheckLength = 5f;
    public float JumpPower = 500f;
    bool onGround = true;
    bool canDoubleJump = false;


    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float sidetranslation = Input.GetAxis("Horizontal") * sidespeed;
        float rotation = Input.GetAxis("Mouse X") * rotationSpeed;
        sidetranslation *= Time.deltaTime;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(sidetranslation, 0, translation);
        transform.Rotate(0, rotation, 0);

        RaycastHit hit;
        Vector3 physicsCentre = this.transform.position +
            this.GetComponent<CapsuleCollider>().center;

        Debug.DrawRay(physicsCentre, Vector3.down * GroundCheckLength, Color.red, 1);
        if (Physics.Raycast(physicsCentre, Vector3.down, out hit, GroundCheckLength))
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
            this.GetComponent<Rigidbody>().AddForce(Vector3.up * JumpPower);
            canDoubleJump = false;
        }
        else if (Input.GetKeyDown("space") && onGround)
        {
            this.GetComponent<Rigidbody>().AddForce(Vector3.up * JumpPower);
            canDoubleJump = true;
        }
    }
}
