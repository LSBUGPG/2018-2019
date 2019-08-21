using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextBoard : MonoBehaviour
{

	public bool isStory;

    GameObject BoardTrigger;
    bool canTrigger;

	public EnemyVanish enemy;


    public Animator animator;

    [SerializeField] private string loadBoard;

	void Start(){
		if (!isStory) {
			enemy = GameObject.FindGameObjectWithTag ("EnemyScript").GetComponent<EnemyVanish> ();
		}
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
			if (!isStory) 
			{
				StartDelay.viewCountSwap = enemy.viewCount;
			}
            canTrigger = false; 
            Debug.Log("Board Trigger");
            animator.SetTrigger("FadeOut");
            canTrigger = false;
            SceneManager.LoadScene(loadBoard);
        }
    }
}