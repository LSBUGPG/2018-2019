using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour {

	List<float> whichNote = new List<float>() {1,6,3,4,2,5,2,1,2,3,5,6,4,6,5,5,1,2,4,1,1,4,5,5}; //set value for notes for now - change later to fit songs - first number in the sequence is the 0 value then 1,2,3 etc
	public int noteMark = 0; //tracking position of notes from list above

	public Transform noteObjectUp; //stores value of the note so it can be instantiated
	public Transform noteObjectRight;
	public Transform noteObjectDown;
	public Transform noteObjectLeft;

	public string timerReset="y";
	public float xPosition;  //x position in which the note is going to be spawned
	public float yPosition;
	public float zPosition; //needed if tilting the game world

	public static float totalScore = 0; //UI stuff

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if ((timerReset == "y") && (noteMark<22)) { //noteMark22 - end of song functionality
			StartCoroutine (spawnNote ());
			timerReset = "n";
		}
	}

	IEnumerator spawnNote() { //IEnymerator does nothing by itself, you have to tell the script to use it
		yield return new WaitForSeconds (1);
		if (whichNote [noteMark] == 1) {
			xPosition = 0.26f; //changes the x position 
			yPosition = 22.77f; //changes the y position
			zPosition = -3.02f;
			Instantiate (noteObjectUp, new Vector3 (xPosition, yPosition, zPosition), noteObjectUp.rotation); //(x,y,z)
		}
		if (whichNote [noteMark] == 2) {
			xPosition = 17.59f;
			yPosition = 5.01f; 
			zPosition = -3.02f;
			Instantiate (noteObjectRight, new Vector3 (xPosition, yPosition, zPosition), noteObjectRight.rotation); //(x,y,z)
		}
		if (whichNote [noteMark] == 3) {
			xPosition = 0.26f; 
			yPosition = -12.99f;
			zPosition = -3.02f;
			Instantiate (noteObjectDown, new Vector3 (xPosition, yPosition, zPosition), noteObjectDown.rotation); //(x,y,z)
		}
		if (whichNote [noteMark] == 4) {
			xPosition = -17.3f;  
			yPosition = 5.01f; 
			zPosition = -3.02f;
			Instantiate (noteObjectLeft, new Vector3 (xPosition, yPosition, zPosition), noteObjectLeft.rotation); //(x,y,z)
		}

		noteMark += 1;
		timerReset = "y";
		//Instantiate (noteObjectUp, new Vector3 (xPosition, 1.2f, -2.18f), noteObjectUp.rotation); //old
	}
}
