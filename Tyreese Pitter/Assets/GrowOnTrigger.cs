using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowOnTrigger : MonoBehaviour {
	
	float ScaY;
	float ScaX;
	float speed = 1f;
	public CountObjects collect;

	// Use this for initialization
	void Start () {
		
		ScaX = transform.localScale.x;
		ScaY = transform.localScale.y;

	}
	
	// Update is called once per frame
	void Update () {

		if (Collect.objects == 0) {
			transform.localScale = new Vector3 (ScaX, ScaY, 0);
			ScaX += speed;
			ScaY += speed;
	}
		if (ScaX > 2) {
			speed = 0f;
		}
		
}
}