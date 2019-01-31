using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float Runspeed;
    public float sidespeed;
    public float rotationSpeed;



    void Start () {
        Cursor.lockState = CursorLockMode.Locked;
    }
	


	void Update () {
        float translation = Input.GetAxis("Vertical") * Runspeed;
        float sidetranslation = Input.GetAxis("Horizontal") * sidespeed;
        float rotation = Input.GetAxis("Mouse X") * rotationSpeed;
        sidetranslation *= Time.deltaTime;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(sidetranslation, 0, translation);
        transform.Rotate(0, rotation, 0);
    }


}
