using UnityEngine;
using System.Collections;
using System;

public class MoveUsingArrowKeys : MonoBehaviour {

	public static Action<float> MoveOnArrows;
	public static Action<float> RotateOnArrows;

	void Update () {
		if (MoveOnArrows != null)
			MoveOnArrows (Input.GetAxis ("Vertical"));

		if (RotateOnArrows != null)
			RotateOnArrows(Input.GetAxis ("Horizontal"));
	}
}
