using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public float speed;
    private float distance = 0.0f;

    private bool movingRight= true;
  
    public Transform grounsDetection;

    void Update(){

        transform.Translate(Vector2.right * speed * Time.deltaTime);

        RaycastHit2D groundInfo = Physics2D.Raycast(grounsDetection.position,Vector2.down,distance);
        if(groundInfo.collider != null){
            if(movingRight == true){
                transform.eulerAngles = new Vector3(0F, -180F, 0F);
                movingRight = false;
            }else{
                transform.eulerAngles = new Vector3(0F, 0F, 0F);
                movingRight = true;
            }
        }
    }


}
