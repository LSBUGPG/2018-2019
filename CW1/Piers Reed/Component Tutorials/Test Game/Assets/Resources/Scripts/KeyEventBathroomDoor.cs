using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyEventBathroomDoor : MonoBehaviour
{
    GameObject eventTrigger;
    bool canTrigger;

    public Animator animator;

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
            Debug.Log("Event Trigger");
            animator.SetTrigger("FadeOutIn");
            canTrigger = false;
            //Scene change or fade
        }
    }
}