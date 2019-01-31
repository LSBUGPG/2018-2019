using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public int playerScore;

	public float highScore;

	public Text scoreTXT;

	public Text highScoreTXT;

	// Use this for initialization
	void Start () {
		highScore = PlayerPrefs.GetInt ("HighScore", 0);
	}
	
	// Update is called once per frame
	void Update () {

		scoreTXT.text = "Score: " + playerScore;

		highScoreTXT.text = "High Score: " + highScore;

	}

	void AddScore (int num){
	
		playerScore += num;
	
	
	}

	void saveScore(){
		if (playerScore > highScore) {
			PlayerPrefs.SetInt ("HighScore", playerScore);
		}
	}

}
