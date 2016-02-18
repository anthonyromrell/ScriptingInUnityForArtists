using UnityEngine;
using System.Collections;
using System;

public class SpawnPoint : MonoBehaviour {

	public static Action<Transform> SendSpawnPoint;
	// Use this for initialization
	void Start () {
		if (SendSpawnPoint != null)
						SendSpawnPoint (transform);
	}

}
