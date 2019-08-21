using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScript : MonoBehaviour {

	public float lifeTime = 13f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (lifeTime > 0) {
			lifeTime -= Time.deltaTime;
			if (lifeTime <=0) {
				Destruction ();
			}
		}

		if (this.transform.position.y <= -15) {
			Destruction ();
		}

	}

	void OnCollisionEnter(Collision cool) {
	if (cool.gameObject.name == "destroyer") {
		Destruction ();
	}
}

    void Destruction () {
	Destroy(this.gameObject);
   }
}
