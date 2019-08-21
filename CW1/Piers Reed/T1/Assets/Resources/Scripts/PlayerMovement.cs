using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Vector3 nextDir;

    public Vector3 currentPosition;



    public float speed = 5f;

    // Use this for initialization
    void Start()
    {
        currentPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position != new Vector3(currentPosition.x, transform.position.y, currentPosition.z) + nextDir)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(currentPosition.x, transform.position.y, currentPosition.z) + nextDir, speed * Time.deltaTime);
        }

        else

        {
            nextDir = Vector3.zero;
            currentPosition = transform.position;

            if (Input.GetAxisRaw("Horizontal") != 0)
            {

                nextDir.z = -Input.GetAxisRaw("Horizontal");
            }

            else if (Input.GetAxisRaw("Vertical") != 0)
            {

                nextDir.x = Input.GetAxisRaw("Vertical");
            }
        }
    }
}
