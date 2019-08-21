using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class triggerwrongaudio : MonoBehaviour {

    public AudioSource wrongaudio;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
            wrongaudio.Play();
    }
}




