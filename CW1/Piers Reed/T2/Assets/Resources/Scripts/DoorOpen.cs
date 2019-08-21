using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorOpen : MonoBehaviour
{
    GameObject SceneTrigger;
    bool canTrigger;

    [SerializeField] private string loadScene;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneTrigger = gameObject;
            canTrigger = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            canTrigger = false;
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && canTrigger)
        {
            Debug.Log("Board Trigger");
            canTrigger = false;
            SceneManager.LoadScene(loadScene);
        }
    }
}