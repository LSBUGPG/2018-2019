using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChanges : MonoBehaviour {

	public Color colour;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {       

		other.GetComponent<Renderer> ().material.color = colour;
	}
}