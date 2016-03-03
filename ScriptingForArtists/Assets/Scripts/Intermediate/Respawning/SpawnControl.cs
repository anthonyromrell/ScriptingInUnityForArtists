using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class SpawnControl : MonoBehaviour
{
	//public static Action 

	public MeshRenderer meshRenderer;
	public Transform RemovedSpawnPoint;
	public SpawnPointList spawnPointList;
	public int health = 5;
	private int reHealth;
	
	void Start () {
		reHealth = health;
	}
	
	IEnumerator Spawn ()
	{
		reHealth = health;
		yield return new WaitForSeconds (2);
		meshRenderer.enabled = true;
		int randomSpawnPointNum = UnityEngine.Random.Range (0, spawnPointList.spawnPoints.Count-1);
		transform.position = spawnPointList.spawnPoints[randomSpawnPointNum].position;
		RemovedSpawnPoint = spawnPointList.spawnPoints [randomSpawnPointNum];
		spawnPointList.spawnPoints.RemoveAt (randomSpawnPointNum);
	}

	void StartSpawn ()
	{
		meshRenderer.enabled = false;
		StartCoroutine (Spawn ());
	}

	void OnMouseDown () {
		if (RemovedSpawnPoint != null) {
			spawnPointList.AddToSpawnPointsList (RemovedSpawnPoint);
			RemovedSpawnPoint = null;
		}

		if (reHealth > 0) {
				reHealth--;
		} else {
				StartSpawn ();
		}
	}
}
