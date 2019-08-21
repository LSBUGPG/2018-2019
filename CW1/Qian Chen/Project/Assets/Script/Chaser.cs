using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Chaser : MonoBehaviour {

	public float speed;

	public Transform lookTarget;

	public int spawnPoint;

	// Use this for initialization
	void Start () {
		speed = Random.Range (5, 13);
		spawnPoint = Random.Range (-13, 13);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.forward * Time.deltaTime * speed);

		transform.LookAt (lookTarget);

	}
		

	void OnTriggerEnter (Collider col){

		if (col.gameObject.tag == "shot") {

			Instantiate (gameObject, new Vector3(spawnPoint, 1, spawnPoint), transform.rotation);
			Instantiate (gameObject, new Vector3(0, 1, 0), transform.rotation);
			Destroy (col.gameObject);
			GameObject temp = GameObject.FindGameObjectWithTag("score");

			temp.SendMessage ("AddScore", 1);

			Destroy (gameObject);
		
		} else if (col.gameObject.tag == "Player") {

			GameObject temp = GameObject.FindGameObjectWithTag("score");

			temp.SendMessage ("saveScore");

			SceneManager.LoadScene ("SampleScene");


		} 
	}

}
