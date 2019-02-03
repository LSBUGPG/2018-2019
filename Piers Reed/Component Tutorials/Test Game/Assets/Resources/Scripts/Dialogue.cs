using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour {

    public GameObject textDisplay;

	// Use this for initialization
	void Start () {
        textDisplay.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.timeSinceLevelLoad > 5f)
        {
            textDisplay.SetActive(false);
        }
    }
}
