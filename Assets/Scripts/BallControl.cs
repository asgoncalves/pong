 using UnityEngine;
using System.Collections;

public class BallControl : MonoBehaviour {

	public Rigidbody2D rigidBody;

	public float ballSpeed = 100;

	// Use this for initialization
	void Start () {
		new WaitForSeconds(2);
		GoBall ();
	}

	void GoBall() {

		float randomNumber = Random.Range (0, 2);
		
		if (randomNumber < 0.5) {
			
			Debug.Log ("shoot right");
			rigidBody.AddForce (new Vector2(ballSpeed, 10));
			
		} else {
			
			Debug.Log ("shoot left");
			rigidBody.AddForce (new Vector2(-ballSpeed, -10));
			
		}
	}

	void OnCollisionEnter2D (Collision2D colliderInfo) {

		if (colliderInfo.collider.tag == "Player") {
			rigidBody.velocity = new Vector2(rigidBody.velocity.x, rigidBody.velocity.y/2 + colliderInfo.collider.attachedRigidbody.velocity.y/3);
		}
	}
}
