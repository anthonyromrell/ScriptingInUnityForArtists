using UnityEngine;
using System.Collections;

public class KillThisEnemy : MonoBehaviour {

	void Start () {
		MyEnums.gameState = MyEnums.gameStates.Attacked;
	}

	void OnMouseUp () {
		MyEnums.gameState = MyEnums.gameStates.Playing;
		this.gameObject.SetActive (false);
	}

	// Update is called once per frame
	void Update () {
		switch (MyEnums.gameState) {
		case MyEnums.gameStates.KillAllEnemies:
			this.gameObject.SetActive(false);
			break;
		}
	}
}
