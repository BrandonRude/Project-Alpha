using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	// double slashes are used for comments

	// speed of player
	public Vector2 speed = new Vector2(1,0);

	// store the speed
	private Vector2 movement;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		// retrive axis information
		float inputX =Input.GetAxis("Horizontal");
		float inputY = Input.GetAxis("Vertical");

		// movement per direction
		movement = new Vector2(
			speed.x * inputX,
			-1);
	
	}

	// Update is called once per fixed frame
	void FixedUpdate() {

		// move the game object
		rigidbody2D.velocity = movement;
	}

}
