using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{



    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Crash")) // the tag allows the code to know when the object has collided with the right object
        {
            Destroy(gameObject); //this means when the collison happens, destroy this object
        }
    }
}
    
