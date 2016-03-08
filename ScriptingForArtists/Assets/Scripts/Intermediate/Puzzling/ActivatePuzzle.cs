using UnityEngine;
using System.Collections;

public class ActivatePuzzle : MonoBehaviour {

	public ColorPuzzleLogic colorPuzzleLogic;

	void OnMouseDown () {
		colorPuzzleLogic.RunLogic (this.name);
	}

	void OnTriggerEnter () {
		colorPuzzleLogic.RunLogic (this.name);
	}
}
