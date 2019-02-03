using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerDamage : MonoBehaviour {

    int HealthUI = 3;
    public int numOfHeart;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    static  int playerHealth = 3;
    int damage = 1;

    [SerializeField] private string loadScene;

    private void Start()
    {
        print(playerHealth);
        HealthUI = playerHealth;
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            playerHealth -= damage;
            HealthUI -= damage;
            print("damage taken" + playerHealth);
        }
    }

    private void Update()
    {
        if (HealthUI > numOfHeart){
            HealthUI = numOfHeart;
        }

        for (int i = 0; i < hearts.Length; i++)
        {
            if(i < HealthUI){
                hearts[i].sprite = fullHeart;
            } else {
                hearts[i].sprite = emptyHeart;
            }
            if(i < numOfHeart){
                hearts[i].enabled = true;
            } else {
                hearts[i].enabled = false;
            }
        }
        if (playerHealth == 0 ){
            SceneManager.LoadScene(loadScene);
        }
    }
}

