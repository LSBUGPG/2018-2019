using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShiftSquare : MonoBehaviour
{


    PlayerController playerController;

    GameObject eventTrigger;
    bool canReveal;

    float timerMax = 1;
    float timer;
    bool isViewing;
    public int viewCount;

    public int shiftCount;

    float posX;
    float posY;
    float posZ;

    public bool shiftRight = false;
    public bool shiftLeft = false;
    public bool shiftUp = false;
    public bool shiftDown = false;

    void Start()
    {
        viewCount = StartDelay.viewCountSwap;
        playerController = FindObjectOfType<PlayerController>();
        canReveal = true;
        posX = transform.parent.position.x;
        posY = transform.parent.position.y;
        posZ = transform.parent.position.z;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            timer = timerMax;
            canReveal = false;
            eventTrigger = gameObject;
            GetComponent<MeshRenderer>().enabled = true;
        }
    }

    private void Update()
    {
        transform.parent.position = new Vector3(posX, posY, posZ);

        if (StartDelay.vanish && canReveal)
        {
            GetComponent<MeshRenderer>().enabled = false;
        }

        if (viewCount < 5 && playerController.canMove)
        {
            if (Input.GetKeyDown(KeyCode.Space) && canReveal && shiftRight)
            {
                Debug.Log("enemy shifted right");
                posZ -= shiftCount;
                shiftRight = false;
                shiftUp = true;
                canReveal = false;
                GetComponent<MeshRenderer>().enabled = false;
                timer = timerMax;
                viewCount++;
            }
            if (Input.GetKeyDown(KeyCode.Space) && canReveal && shiftUp)
            {
                Debug.Log("enemy shifted right");
                posX += shiftCount;
                shiftLeft = true;
                shiftUp = false;
                canReveal = false;
                GetComponent<MeshRenderer>().enabled = false;
                timer = timerMax;
                viewCount++;
            }
            if (Input.GetKeyDown(KeyCode.Space) && canReveal && shiftLeft)
            {
                Debug.Log("enemy shifted right");
                posZ += shiftCount;
                shiftLeft = false;
                shiftDown = true;
                canReveal = false;
                GetComponent<MeshRenderer>().enabled = false;
                timer = timerMax;
                viewCount++;
            }
            if (Input.GetKeyDown(KeyCode.Space) && canReveal && shiftDown)
            {
                Debug.Log("enemy shifted right");
                posX -= shiftCount;
                shiftRight = true;
                shiftDown = false;
                canReveal = false;
                GetComponent<MeshRenderer>().enabled = false;
                timer = timerMax;
                viewCount++;
            }
        }
        if (!canReveal)
        {
            timer -= 1 * Time.deltaTime;

            if (timer <= 0)
            {
                GetComponent<MeshRenderer>().enabled = false;
                canReveal = true;
            }
        }
    }
}