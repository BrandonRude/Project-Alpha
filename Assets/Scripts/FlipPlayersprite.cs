using UnityEngine;
using System.Collections;

public class FlipPlayersprite : MonoBehaviour {

	// variable to show player facing
	bool facingRight = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	// retrive axis information
		float inputX =Input.GetAxisRaw("Horizontal");
		float inputY = Input.GetAxis("Vertical");

		// Flip character model
		if (inputX < 0 && facingRight == true){
			Flip();
		} else if(inputX > 0 && facingRight == false){
			Flip();
		}
	}
		void Flip() {
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
		facingRight = !facingRight;

	}
}
