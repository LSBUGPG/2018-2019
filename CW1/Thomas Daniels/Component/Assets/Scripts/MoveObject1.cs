using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveObject1 : MonoBehaviour
{

    public Transform player;
    public Transform playerCam;
    bool hasPlayer = false;
    bool beingCarried = false;
    public GameObject item;
    private bool touched = false;
   
    Vector3 originalPos;
    Quaternion originalRot;
    
    // Use this for initialization
    void Start()
    {

        originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        originalRot = Quaternion.Euler(gameObject.transform.rotation.x, gameObject.transform.rotation.y, gameObject.transform.rotation.z);

    }



    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "teleport")
        {
            gameObject.transform.position = originalPos;
            gameObject.transform.rotation = originalRot;
        }
    }

    private void Update()
    {
        float dist = Vector3.Distance(gameObject.transform.position, player.position);
        if (dist <= 2.5f)
        {
            if (Input.GetKey(KeyCode.Mouse0) && Input.GetKey(KeyCode.Mouse1))
            {
                Destroy(item);  
            }

            hasPlayer = true;
        }
        else
        {
            hasPlayer = false;
        }
            if (hasPlayer && Input.GetMouseButton(0))
            {
                GetComponent<Rigidbody>().isKinematic = true;
                transform.parent = playerCam;
                beingCarried = true;
            }
            else
            {
                GetComponent<Rigidbody>().isKinematic = false;
                transform.parent = null;
                beingCarried = false;
            }
            if (beingCarried)
            {
                if (touched)
                {
                    GetComponent<Rigidbody>().isKinematic = false;
                    transform.parent = null;
                    beingCarried = false;
                    touched = false;
                }

            }
        }


    }

