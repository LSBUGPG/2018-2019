using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyVanish : StartDelay
{

	PlayerController playerController;

    GameObject eventTrigger;
    bool canReveal;

	float timerMax = 1;
	float timer;
	bool isViewing;
	public int viewCount;

	void Start()
    {
		viewCount = StartDelay.viewCountSwap;
		playerController = FindObjectOfType<PlayerController>();
		canReveal = true;
	}

    private void Update()
    {
		if (StartDelay.vanish && canReveal)
        {
            GetComponent<MeshRenderer>().enabled = false;
        }

		if (viewCount < 5 && playerController.canMove) 
		{ 
            if (Input.GetKeyDown (KeyCode.Space) && canReveal) 
			{
				canReveal = false;
				GetComponent<MeshRenderer> ().enabled = true;
				timer = timerMax;
				viewCount++;
			}
        }
		if (!canReveal) 
		{
			timer -= 1 * Time.deltaTime;

			if (timer <= 0) {
				GetComponent<MeshRenderer> ().enabled = false;
				canReveal = true;
			}
		}
     }
}
