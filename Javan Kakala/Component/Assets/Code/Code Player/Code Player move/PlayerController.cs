using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour{

    public float speed;
    public float jumpForce;
    private float moveInput;

    private Rigidbody2D rb;

    private bool facingRight = true;


    private bool isGrounded;
    public Transform groundcheck;
    public float checkRadius;
    public LayerMask whatIsGround;

   private int extrajumps;
    public int extrajumpsValue;

    void start(){
        extrajumps = extrajumpsValue; 
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {

        isGrounded = Physics2D.OverlapCircle(groundcheck.position,checkRadius,whatIsGround);

        moveInput = Input.GetAxis("horizontal");
        Debug.Log(moveInput);
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        if (facingRight == false && moveInput > 0)
        {
            Flip();
        }
        else if (facingRight == true && moveInput < 0){
            Flip();
     }
  }

    void Update(){

        if (isGrounded == true){
            extrajumps = extrajumpsValue;
        }
        
        if (Input.GetKeyDown(KeyCode.UpArrow) && extrajumps > 0){
            rb.velocity = Vector2.up * jumpForce;
            extrajumps--;
        } else if(Input.GetKeyDown (KeyCode.UpArrow ) && extrajumps == 0 && isGrounded == true){
            rb.velocity = Vector2.up * jumpForce;

        }
    }
    void Flip(){

        facingRight = !facingRight;
        Vector3 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;
    }
}
