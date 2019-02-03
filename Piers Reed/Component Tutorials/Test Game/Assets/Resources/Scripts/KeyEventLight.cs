using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyEventLight : MonoBehaviour
{
    GameObject eventTrigger;
    bool canTrigger;


    public Light light;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            eventTrigger = gameObject;
            canTrigger = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            canTrigger = false;
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && canTrigger)
        {
            light.intensity = 0.64f;
        }
    }
}

