using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	void StopGame ()
	{
		print ("Game Over");
		Death.GameOver -= StopGame;
	}

	// Use this for initialization
	void Start () {
		Death.GameOver += StopGame;	
	}

}
