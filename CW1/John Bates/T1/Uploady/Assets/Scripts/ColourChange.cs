using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChange : MonoBehaviour {

	Renderer myRenderer;

	// Use this for initialization
	void Start () {
		myRenderer = GetComponent<Renderer> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.R)) {
			myRenderer.material.color = Color.red;
		}
		if(Input.GetKeyDown (KeyCode.B)) {
			myRenderer.material.color = Color.blue; 
		}
	} 
}