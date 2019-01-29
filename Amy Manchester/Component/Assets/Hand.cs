using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    float posX;
    float posY;
    float posZ;
    float speed = 0.2f;
    // Use this for initialization
    void Start()
    {
        posX = transform.position.x;
        posY = transform.position.y;
        posZ = transform.position.z;
    }
    // Update is called once per frame
    void Update()
    {
        posX -= speed;
        transform.position = new Vector4(posX, posY, posZ, -0);
        if (posX < -10f)
        {
            posX = 10f;
        }
    }
}
