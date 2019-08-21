using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upright : MonoBehaviour
{

    new protected Rigidbody rigidbody;
    public bool StayUpright = true;
    public float UprightForce = 220;
    public float offset = 1.45f;
    public float ExtraUpwardForce = -5;
    public float dampenAngularForce = 0;
	public float recoverSpeed = 0.05f;

	float currentForce = 0.0f;

    // Use this for initialization
    void Awake()
    {
		currentForce = UprightForce;
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.maxAngularVelocity = 40;
    }

     //Update is called once per frame
    	void Update () {
    			if (Input.GetKeyDown (KeyCode.Q)) {
					currentForce = 0.0f;
    				StayUpright = !StayUpright;
    			}
    	}

    void FixedUpdate()
    {
        if (StayUpright)
        {
			if (currentForce < UprightForce)
			{
				currentForce = Mathf.Lerp(currentForce, UprightForce, recoverSpeed);
			}
            rigidbody.AddForceAtPosition(
                Vector3.up * currentForce,
            	transform.position + transform.TransformPoint(new Vector3(0, offset, 0)), 
				ForceMode.Force);

            //rigidbody.AddForceAtPosition(new Vector3(0, -UprightForce, 0),
            //transform.position + transform.TransformPoint(new Vector3(0, -offset, 0)), ForceMode.Force);
        }
        if (dampenAngularForce > 0)
        {
            rigidbody.angularVelocity *= (1 - Time.deltaTime * dampenAngularForce);
        }
    }


}



