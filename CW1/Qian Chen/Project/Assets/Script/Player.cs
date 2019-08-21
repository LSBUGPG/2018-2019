using UnityEngine.AI;
using UnityEngine;

public class Player : MonoBehaviour {

	private CharacterController player;

	public float Speed;

	public float rayLength;

	Camera mainCamera;

	void Start () {
		player = GetComponent<CharacterController> ();
		mainCamera = FindObjectOfType<Camera>();
	}

	void Update () {
		
	    Vector3 Move = Vector3.zero;
		Move.x = Input.GetAxis ("Horizontal") * Speed;
		Move.z = Input.GetAxis ("Vertical") * Speed;
		player.Move(Move * Time.deltaTime);

		Ray cameraRay = mainCamera.ScreenPointToRay (Input.mousePosition);

		Plane ground = new Plane (Vector3.up, Vector3.zero);

		if (ground.Raycast(cameraRay, out rayLength)) {

			Vector3 lookTarget = cameraRay.GetPoint (rayLength);

			transform.LookAt (new Vector3(lookTarget.x, transform.position.y, lookTarget.z));
		}
			

	}
}
