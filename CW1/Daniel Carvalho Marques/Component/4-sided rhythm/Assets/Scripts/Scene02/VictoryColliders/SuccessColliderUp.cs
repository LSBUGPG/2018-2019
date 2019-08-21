using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuccessColliderUp : MonoBehaviour {

	public string lockInput = "n";

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		if ((Input.GetKeyDown(KeyCode.UpArrow)) && (lockInput=="n")){

			lockInput = "y";
			GetComponent<Rigidbody> ().velocity = new Vector3 (0, 2, 0);

			StartCoroutine (retractCollider ());
		}
	}
	IEnumerator retractCollider() {
		yield return new WaitForSeconds (.75f);
		GetComponent<Rigidbody> ().velocity = new Vector3 (0, -2, 0);
		yield return new WaitForSeconds (.75f);
		GetComponent<Rigidbody> ().velocity = new Vector3 (0, 0, 0);
		lockInput = "n";
	}
}
