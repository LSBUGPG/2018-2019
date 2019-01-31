using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrapplingHook : MonoBehaviour {


    public Transform cam;
    private RaycastHit hit;
    private Rigidbody rb;
    public bool attached = false;
    public float momentum;
    public float speed;
    private float step;
    public LineRenderer LR;
    public Vector3 location;
    public Transform Grapple;


    void Start () {
        momentum = 0;
        rb = GetComponent<Rigidbody>();
    }
	




	void Update () {
        if (Input.GetButtonDown("Fire2"))
        {
            if (Physics.Raycast(cam.position, cam.forward, out hit, 100))
            {
                location = hit.point;
                attached = true;
                rb.isKinematic = true;
                LR.enabled = true;
                LR.SetPosition(1, location);
            }
        }

        if (Input.GetButtonUp("Fire2"))
        {
            attached = false;
            rb.isKinematic = false;
            rb.velocity = cam.forward * momentum;
            LR.enabled = false;
        }

        if (attached)
        {
            momentum += Time.deltaTime * speed;
            step = momentum * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, hit.point, step);
            LR.SetPosition(0, Grapple.position);
        }

        if (momentum >= 35)
        {
            momentum = 35;
        }

        if (!attached && momentum >= 0)
        {
            momentum -= Time.deltaTime * 15;
            step = 0;
        }
    }
}
