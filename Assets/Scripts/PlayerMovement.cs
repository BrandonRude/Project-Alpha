using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {


	// speed of player
	public Vector3 speed = new Vector3(2,0);


	// store the speed
	private Vector3 movement;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		// retrive axis information
		float inputX =Input.GetAxisRaw("Horizontal");
		float inputY = Input.GetAxis("Vertical");

		// movement per direction
		movement = new Vector3(
		speed.x * inputX,
		rigidbody2D.velocity.y);
	}

		void FixedUpdate() {

		// move the game object
		rigidbody2D.velocity = movement;
	}

}
