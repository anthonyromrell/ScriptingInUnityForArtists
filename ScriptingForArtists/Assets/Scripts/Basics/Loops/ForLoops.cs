using UnityEngine;
using System.Collections;

public class ForLoops : MonoBehaviour {

	public int[] playerScores;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < playerScores.Length; i++) {
			playerScores[i] += 10;
			playerScores[i] += 10;
			print (playerScores[i]);
			print (i);
		}
	}
}