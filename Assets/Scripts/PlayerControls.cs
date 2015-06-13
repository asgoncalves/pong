using UnityEngine;
using System.Collections;

public class PlayerControls : MonoBehaviour {

	public KeyCode moveUp;
	public KeyCode moveDown;

	public float speed = 10;

	public Rigidbody2D rigidBody;

	float currentYVelocity;

	void Start() {

		// load rigid body
		Rigidbody2D rigidBody = (Rigidbody2D) GetComponent<Rigidbody2D>();
	
	}

	// Update is called once per frame
	void Update () {
	
		if (Input.GetKey(moveUp)) {

			currentYVelocity = speed;

		} else if (Input.GetKey(moveDown)) {

			currentYVelocity = -speed;
		
		} else {
				
			currentYVelocity = 0;

		}

		rigidBody.velocity = new Vector2 (0, currentYVelocity);
	}
}
