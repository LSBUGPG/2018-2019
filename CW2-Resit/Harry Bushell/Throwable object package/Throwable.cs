using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throwable : MonoBehaviour {

	public float ThrowForce = 1000;
	Vector3 ObjectPosition;
	float distance;
	public float DistanceLimit = 4f;
    public AudioClip Hi;
    public AudioClip Nyoom;
    public float Volume;
    AudioSource Sound;
    public bool Holdable = true;   //this bool to check whether an object an be picked up and thrown
	public GameObject item;
	public GameObject tempParent; //
	public bool isHolding = false; // this bool to checks whether an object is being held
    public bool Played = false;
    Rigidbody physics;				
	// Use this for initialization
	void Start () {
		physics = item.GetComponent<Rigidbody> (); // at the start of the scene we cache the objects rigidbody
        Sound = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () 
	{
		distance = Vector3.Distance (item.transform.position, tempParent.transform.position); //setting a variable for the distance between the object (ball) and it's temporary parent (the player)
		if (distance >= DistanceLimit)
		{
			isHolding = false;				//if the object is too far from the player isHolding becomes false and the ball is released
		}

		if (isHolding == true) 
		{
            if (!Played)
            {
                Sound.PlayOneShot(Hi, Volume);
                Played = true;
            }
            physics.velocity = Vector3.zero;				//when it is being held, all of the forces acting upon the object are set to zero
			physics.angularVelocity = Vector3.zero;
			item.transform.SetParent(tempParent.transform);		//parents the object to the player

			if (Input.GetMouseButtonDown (1))
			{
				physics.AddForce (tempParent.transform.forward * ThrowForce); //when the player right clicks, isHolding becomes false, releasing the object and the ThrowForce is added as force, r
                Sound.PlayOneShot(Nyoom, Volume);

                isHolding = false;
                Played = false;
			}
            if (Input.GetKeyDown (KeyCode.C))
            {
                physics.AddForce(tempParent.transform.forward * ThrowForce); //when the player right clicks, isHolding becomes false, releasing the object and the ThrowForce is added as force, r
                Sound.PlayOneShot(Nyoom, Volume);

                isHolding = false;
                Played = false;
            }
        }
		else 
		{
			//ObjectPosition = item.transform.position; //saves the position of the object when released
			item.transform.SetParent(null, true);		//unparents the object
			physics.useGravity = true;
//			item.transform.position = ObjectPosition;
		}
	}
	void OnMouseDown()
	{
		Debug.Log (distance);
		if (distance <= DistanceLimit)
		{
			isHolding = true;//When the mouse is clicked on an object, the isHolding bool is changed to true,
			physics.useGravity = false;				// the item no longer obeys the laws of gravity (so that it can be carried)
			physics.detectCollisions = true;
		}
	}
	void OnMouseUp()
	{
		isHolding = false;
	}
}
