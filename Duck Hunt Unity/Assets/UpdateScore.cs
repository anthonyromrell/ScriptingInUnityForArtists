using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UpdateScore : MonoBehaviour {

	public Canvas myCanvas;

	public Text scoreText;

	// Update is called once per frame
	void Update () {
		scoreText.text = "Score: " + StaticVars.gameScore.ToString();
	}
}
