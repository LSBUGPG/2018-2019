using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartDelay : MonoBehaviour
{
    PlayerController player;
    public GameObject countDown;
	public static bool vanish;
	public static int viewCountSwap;

    // Use this for initialization
    void Start()
    {
        player = FindObjectOfType<PlayerController>();
		vanish = false;
        StartCoroutine("Startdelay");
    }

    // Update is called once per frame
        IEnumerator Startdelay()
        {
        player.canMove = false;
            Time.timeScale = 0;
            float pauseTime = Time.realtimeSinceStartup + 6f;
            while (Time.realtimeSinceStartup < pauseTime)
                yield return 0;
            countDown.gameObject.SetActive(false);
            Time.timeScale = 1;
		vanish = true;
        player.canMove = true;

    }
    }
