using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {

	public string GameLevel = "GameLevel";

	public void Play ()
	{
		Application.LoadLevel (GameLevel);
	}
}
