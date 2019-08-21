using UnityEngine;
using System.Collections;

public class PickupMovement : MonoBehaviour {
	public float multiplier = 1.4f;

	void Update () 
	{
		transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
	}
}