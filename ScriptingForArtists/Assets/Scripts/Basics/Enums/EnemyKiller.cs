using UnityEngine;
using System.Collections;

public class EnemyKiller : MonoBehaviour {

	// Use this for initialization
	void OnMouseUp () {
		MyEnums.gameState = MyEnums.gameStates.KillAllEnemies;
		this.gameObject.SetActive (false);
	}
}
