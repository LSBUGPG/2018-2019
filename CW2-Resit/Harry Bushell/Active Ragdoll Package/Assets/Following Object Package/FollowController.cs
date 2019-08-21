using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowController : MonoBehaviour {
	bool followMe;
	public List<GameObject> followers = new List<GameObject> ();
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.F)) 
		{
			followMe = !followMe;
			foreach (GameObject follower in followers) {
				if (followMe) {
					follower.SendMessage ("FollowMe", transform);
				} else {
					follower.SendMessage ("StopFollowing");
				}
			}
		}
	}
}
