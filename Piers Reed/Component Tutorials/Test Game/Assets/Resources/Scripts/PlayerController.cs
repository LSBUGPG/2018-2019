using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public Vector3 nextDir;

    public float jumpForce = 0;

    public float speed = 5;
    public float speedRot = 100;

    public float rotationOffset;

    public float roomSizeZMax, roomSizeZMin;
    public float roomSizeXMax, roomSizeXMin;

    public Vector3 curPosition;

    public bool canMove;

	public RectTransform text;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "NonWalk")
        {
            nextDir.x = 0;
            nextDir.y = 0;
            nextDir.z = 0;
            Debug.Log("collision");
        }
    }

	void OnTriggerEnter(Collider collision)
	{
		if (collision.gameObject.tag == "Enemy") 
		{
			nextDir.x = 0;
			nextDir.y = 0;
			nextDir.z = 0;
        }
	}

    void Start()
    {

        curPosition = transform.position;

    }
		
    void Update()
    {
		if (text != null) {
			text.eulerAngles = new Vector3 (0, 50.698f, 0);
		}

        if(canMove)
        {

            if (transform.position != new Vector3(curPosition.x, transform.position.y, curPosition.z) + nextDir)
            {

                transform.position = Vector3.MoveTowards(transform.position, new Vector3(curPosition.x, transform.position.y, curPosition.z) + nextDir, speed * Time.deltaTime);

                transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(Quaternion.Euler(0, rotationOffset, 0) * nextDir), speedRot * Time.deltaTime);

            }
            else
            {
                nextDir = Vector3.zero;
                curPosition = transform.position;
                curPosition.x = Mathf.Round(curPosition.x);
                curPosition.y = Mathf.Round(curPosition.y);


                if (Input.GetAxisRaw("Horizontal") != 0)
                {
                    float directionZ = -Input.GetAxisRaw("Horizontal");

                    if (curPosition.z + directionZ < roomSizeZMax && curPosition.z + directionZ > roomSizeZMin)
                    {
                        nextDir.z = directionZ;
                    }



                }
                else if (Input.GetAxisRaw("Vertical") != 0)
                {
                    float directionX = -Input.GetAxisRaw("Vertical");

                    if (curPosition.x - directionX < roomSizeXMax && curPosition.x - directionX > roomSizeXMin)
                    {
                        nextDir.x = Input.GetAxisRaw("Vertical");
                    }
                }
            }
        }
    }
}