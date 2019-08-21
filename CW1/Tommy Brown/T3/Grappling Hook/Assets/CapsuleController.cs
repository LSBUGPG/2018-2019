using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleController : MonoBehaviour
{

    public float speed = 10f;
    public float sidespeed = 10f;
    public float rotationSpeed = 100f;


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
    }
}
