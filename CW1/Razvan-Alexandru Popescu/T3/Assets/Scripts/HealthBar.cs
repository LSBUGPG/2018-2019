using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class HealthBar : MonoBehaviour {

	public Image HPbar;
	public Text ratiotext;

	private float hitpoint = 100;
	private float maxHitpoint = 100;

	private void Start() {
		
		UpdateHeathbar ();

	}

	private void UpdateHeathbar() {

		float ratio = hitpoint / maxHitpoint;
		HPbar.rectTransform.localScale = new Vector3 (ratio, 1, 1);
		ratiotext.text = (ratio*100).ToString("0") + '%';
	}

	private void TakeDamage(float damage) {

		hitpoint -= damage;
		if (hitpoint < 0) {
			hitpoint = 0;
			Debug.Log ("Dead!");
		}

		UpdateHeathbar ();

	}
}
