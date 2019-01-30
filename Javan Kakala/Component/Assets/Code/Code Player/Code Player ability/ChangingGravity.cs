using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingGravity : MonoBehaviour {
    private Rigidbody2D rb;
    private bool top;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    { if (Input.GetKeyDown(KeyCode.LeftArrow)){
         Physics2D.gravity = new Vector2(-9.81f, 0f);
        }else if (Input.GetKeyDown(KeyCode.DownArrow)){
         Physics2D.gravity = new Vector2(-9.81f, 0f);
        }else if (Input.GetKeyDown(KeyCode.UpArrow))
        Physics2D.gravity = new Vector2(-9.81f, 0f);
        else if (Input.GetKeyDown(KeyCode.RightArrow)){
         Physics2D.gravity = new Vector2(-9.81f, 0f);

        if (Input.GetKeyDown(KeyCode.Q))
            rb.gravityScale *= -1;
        Rotation();
    }

}
void Rotation(){
        if (top == false)
        {
            transform.eulerAngles = new Vector3(0, 0, 100f);
        }else {
            transform.eulerAngles = Vector3.zero;
        }
        
        top = !top;
    }
        
 }
    

