using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour {


	public GameObject objGetTP;
	public GameObject teleHere;
    public GameObject WP;

	void Start () {
        WP.SetActive(false);
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            WP.SetActive(true);
            StartCoroutine (turnoff ());
        }
    }

    IEnumerator turnoff()
    {
        yield return new WaitForSeconds(2f);
        WP.SetActive(false);
    }

    void OnTriggerStay (Collider other)
	{

		if (other.gameObject.tag == "Player") {
			objGetTP.transform.position = teleHere.transform.position;
		}
	}

}




