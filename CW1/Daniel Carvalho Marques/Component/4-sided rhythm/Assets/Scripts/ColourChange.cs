using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChange : MonoBehaviour {

	//https://answers.unity.com/questions/1255990/how-to-change-the-color-of-an-object-when-it-colli.html simmilar thing on forums

	public Color colour;
	//public Color bluecolour;
	//public Color greencolour;
	//public Color yellowcolour;

	// Use this for initialization
	void Start () 
	{


	}
	
	// Update is called once per frame
	void Update () {
		
	}


void OnTriggerEnter(Collider other) {

	//if (other.gameObject.CompareTag ("RedCube")) 
	//{           

		other.GetComponent<Renderer>().material.color= colour;
	//}
	//
	//if (other.gameObject.CompareTag ("BlueCube")) 
	//{            
	//	
	//	transform.GetComponent<Renderer>().material.color= bluecolour;
	//}
}
}