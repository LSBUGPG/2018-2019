using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed = 18;
    public int points = 0;
    private Rigidbody rig;

	// Use this for initialization
	void Start () {

        rig = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(hAxis, 0, vAxis) * speed * Time.deltaTime;
        rig.MovePosition(transform.position + movement);
	}

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 20), "Score : " + points);
    }
}
