using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement1 : MonoBehaviour {
    float posX;
    float posY;
    float speed = 0.5f;
    float yspeed = 0.5f;

    // Use this for initialization
    void Start() {
        posX = transform.position.x;
        posY = transform.position.y;
    }

    // Update is called once per frame
    void Update() {
        transform.position = new Vector3(posX, posY, 0);

        if (Input.GetKey(KeyCode.UpArrow))
        {
            posY += yspeed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            posY -= yspeed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            posX -= speed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            posX += speed;
        }

        }
    }


