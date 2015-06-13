using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	static public int scorePlayerOne = 0;
	static public int scorePlayerTwo = 0;

	public GUISkin scoreSkin;

	// Update is called once per frame
	public static void Score (string wallName) {

		if (wallName == "RightWall") {

			scorePlayerOne += 1;
		
		} else if (wallName == "LeftWall") {

			scorePlayerTwo += 1;

		}

		Debug.Log ("PlayerOne: " + scorePlayerOne);
		Debug.Log ("PlayerTwo: " + scorePlayerTwo);
	}

	void OnGUI() {

		GUI.skin = scoreSkin;
		GUI.Label (new Rect (Screen.width / 2 - 150 -12, 10, 100, 100), "" + scorePlayerOne);
		GUI.Label (new Rect (Screen.width / 2 + 150 -12, 10, 100, 100), "" + scorePlayerTwo);

	}
}
