using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour {

	public Camera mainCamera;
	public BoxCollider2D topWall;
	public BoxCollider2D bottomWall;
	public BoxCollider2D leftWall;
	public BoxCollider2D rightWall;

	public Transform playerOne;
	public Transform playerTwo;

	void Start () {
	
		// move each wall to its edge location
		topWall.size = new Vector2 (mainCamera.ScreenToWorldPoint(new Vector3(Screen.width * 2f, 0f, 0f)).x, 1f);
		topWall.offset = new Vector2 (0f, mainCamera.ScreenToWorldPoint (new Vector3 (0f, Screen.height, 0f)).y + 0.5f) ;

		bottomWall.size = new Vector2 (mainCamera.ScreenToWorldPoint(new Vector3(Screen.width * 2f, 0f, 0f)).x, 1f);
		bottomWall.offset = new Vector2 (0f, mainCamera.ScreenToWorldPoint (new Vector3 (0f, 0f, 0f)).y - 0.5f) ;

		leftWall.size = new Vector2 (1f, mainCamera.ScreenToWorldPoint(new Vector3(0f, Screen.height * 2f, 0)).y);
		leftWall.offset = new Vector2 (mainCamera.ScreenToWorldPoint (new Vector3 (0f, 0f, 0f)).x - 0.5f, 0f) ;

		rightWall.size = new Vector2 (1f, mainCamera.ScreenToWorldPoint(new Vector3(0f, Screen.height * 2f, 0)).y);
		rightWall.offset = new Vector2 (mainCamera.ScreenToWorldPoint (new Vector3 (Screen.width, 0f, 0f)).x + 0.5f, 0f) ;

		playerOne.position = new Vector2(mainCamera.ScreenToWorldPoint (new Vector3 (75f, 0f, 0f)).x, 0f);
		playerTwo.position = new Vector2(mainCamera.ScreenToWorldPoint (new Vector3 (Screen.width - 75f, 0f, 0f)).x, 0f);

	}
}
