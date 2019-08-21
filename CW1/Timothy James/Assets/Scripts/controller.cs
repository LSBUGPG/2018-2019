using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour {

    public float speed = 10.0f;
    public float rotationspeed = 250.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float translationX = Input.GetAxis("Horizontal") * speed;
        float translationZ = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Mouse X") * rotationspeed;

        translationZ *= Time.deltaTime;
        translationX *= Time.deltaTime;
        rotation *= Time.deltaTime;

        transform.Translate(translationX, 0, translationZ);
        transform.Rotate(0, rotation, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {

            Destroy(other.gameObject);
        }
    }
}
