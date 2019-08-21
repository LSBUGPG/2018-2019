using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chaser : MonoBehaviour {

	//public GameObject target;
	public float speed;
	public Transform targetTransform;


	// Use this for initialization
	void Start () {
		//targetTransform = target.transform;
	}
	
	// Update is called once per frame
	void Update () {
		follow ();

	}

	void follow(){

		transform.Translate (Vector3.forward * Time.deltaTime * speed);

		transform.LookAt (targetTransform);

	}

}
