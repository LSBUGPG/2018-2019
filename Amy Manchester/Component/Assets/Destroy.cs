using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Crash"))
        {
            Destroy(gameObject);
        }
    }
}