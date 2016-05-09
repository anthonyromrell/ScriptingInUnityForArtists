using UnityEngine;
using System.Collections;
using System;

public class Death : MonoBehaviour {

	public static Action GameOver;

	void OnTriggerEnter () {
		if (GameOver != null)
			GameOver ();

		gameObject.SetActive (false);
	}

}
