using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchView : MonoBehaviour {
    public bool viewchange = false;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (viewchange == false)
            {
                viewchange = true;
            }
            else
            {
                viewchange = false;
            }
        }
    }
}
