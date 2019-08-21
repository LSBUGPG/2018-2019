using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSprite : MonoBehaviour {


    
    private Renderer rend;


    [SerializeField]
    private Color colorToTurnTo = Color.white;

    private void Start()
    {

        // Assign Renderer component to rend variable
        rend = GetComponent<Renderer>();

        // Change sprite color to selected color
        rend.material.color = colorToTurnTo;
    }
}
