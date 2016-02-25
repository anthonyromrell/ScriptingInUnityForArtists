using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnPointList : MonoBehaviour {

	public List<Transform> spawnPoints;
	
	public void AddToSpawnPointsList (Transform _spawnPoint) {
		spawnPoints.Add (_spawnPoint);
	}

	void Start () {
		spawnPoints = new List<Transform> ();
		SetThisAsSpawnPoint.PassTransformAsSpawnPoint += AddToSpawnPointsList;
	}
}
