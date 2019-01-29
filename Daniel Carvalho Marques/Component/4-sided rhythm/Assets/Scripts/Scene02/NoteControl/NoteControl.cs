using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoteControl : MonoBehaviour {

	//public Text MyText; old UI
	//private int score; old UI

	// Use this for initialization
	void Start () {
		
		//MyText.text = ""; old UI
	}
	
	// Update is called once per frame
	void Update () {

		//MyText.text = "" + score; old UI
	}

	void OnTriggerEnter(Collider other) {

		//score = score + 1; old UI

		if (other.gameObject.tag == "failCollider") {
			Destroy (gameObject);
			Debug.Log ("Fail note press!!!");
			GameMaster.totalScore -= 1; //minus points for failure to press key in time

		}

		if (other.gameObject.tag == "successCollider") {
			Destroy (gameObject);
			Debug.Log ("Successful note press!!!");
			GameMaster.totalScore += 10; //points for successful press of key
		}
	}
  }

