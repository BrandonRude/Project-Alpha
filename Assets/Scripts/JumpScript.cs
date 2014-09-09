using UnityEngine;
using System.Collections;

public class JumpScript : MonoBehaviour {

	//Jump force
	public float jumpForce = 250f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Jump")){
			Jump();
		}
	}

	// Jump action
	void Jump ()
	{
		rigidbody2D.AddForce( new Vector2(0, jumpForce));		
	}
}
