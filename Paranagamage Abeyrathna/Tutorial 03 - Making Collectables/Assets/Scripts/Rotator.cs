﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{

    public float speed = 10f; //Adding a Rotation Speed
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(30, 0, 0) * Time.deltaTime * speed); //Making the "x" axis rotate
    }
}

