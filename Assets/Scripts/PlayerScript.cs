using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	// double slashes are used for comments

	// speed of player
	public Vector3 speed = new Vector3(2,0);

	// Jump speed
	public float jumpForce = 250f;

	// store the speed
	private Vector3 movement;

	// variable to show player facing
	bool facingRight = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		// retrive axis information
		float inputX =Input.GetAxis("Horizontal");
		float inputY = Input.GetAxis("Vertical");

		// Flip character model
		if (inputX < 0 && facingRight == true){
			Flip();
		} else if(inputX > 0 && facingRight == false){
			Flip();
		}

		// movement per direction
		movement = new Vector3(
			speed.x * inputX,
			rigidbody2D.velocity.y);
		/*Trying to get the player to immediately stop moving when key is not pressed

		if(Input.GetButtonUp("Horizontal")){

			Debug.Log(rigidbody2D.velocity);

		}

		// Jump
		if(Input.GetButtonDown("Jump")){
			rigidbody2D.AddForce( new Vector2(0, jumpForce));
		}*/
	
	}

	// Update is called once per fixed frame
	void FixedUpdate() {

		// move the game object
		rigidbody2D.velocity = movement;
	}

	void Flip() {
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
		facingRight = !facingRight;

	}
}
