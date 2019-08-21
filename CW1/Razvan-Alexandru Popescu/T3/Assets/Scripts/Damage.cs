using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour {

	public bool damageToGive;
	public float damage = 10;

	public void OnTriggerStay(Collider col) {
		if (col.tag == "Player") {
			col.SendMessage ((damageToGive) ? "TakeDamage" : "HealDamage", Time.deltaTime * damage);
		}


	}
}
