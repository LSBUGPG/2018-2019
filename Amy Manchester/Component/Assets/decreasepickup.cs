using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class decreasepickup : MonoBehaviour {
    public float speed;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PU Decrease"))

        {
            other.gameObject.SetActive(false);
            speed = speed - 3;
        }
    }
}