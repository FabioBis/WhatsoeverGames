using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour {

	// Use this for initialization
	RaycastHit2D raycast;
	float moveSpeed = 8;
	float horMove = 0;
	float jumpForce = 80;
	void Start () {
	
	}



	// Update is called once per frame
	void Update () {
		horMove = Input.GetAxis ("Horizontal");
		rigidbody2D.velocity =new Vector2 (horMove * moveSpeed, rigidbody2D.velocity.y);
		if (Input.GetKeyDown(KeyCode.Space) == true) {
				rigidbody2D.AddForce(Vector2.up * jumpForce);
		 }
	}
}
