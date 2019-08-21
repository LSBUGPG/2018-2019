using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewObject1 : MonoBehaviour {
    public SwitchView switchview;
    Renderer rend;
    // Use this for initialization
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (switchview.viewchange == true)
        {
            rend.enabled = true;
        }
        else
        {
            rend.enabled = false;
        }
    }
}
