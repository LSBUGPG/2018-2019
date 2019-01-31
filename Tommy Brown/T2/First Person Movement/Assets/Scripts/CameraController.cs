using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour{
    public float camrot = 100.0f;


    void Start()
    {

    }


    void Update()
    {
        float rotation = Input.GetAxis("Mouse Y") * camrot * -1;
        rotation *= Time.deltaTime;
        transform.Rotate(rotation, 0, 0);
    }
}
