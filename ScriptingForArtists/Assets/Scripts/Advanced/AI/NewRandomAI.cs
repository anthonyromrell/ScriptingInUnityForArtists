using UnityEngine;
using System.Collections;

public class NewRandomAI : MonoBehaviour {

	NavMeshAgent enemyAgent;
	public Transform[] destinations;
	private int randomNum = 0;

	// Use this for initialization
	void Start () {
		enemyAgent = GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(enemyAgent.remainingDistance < 0.5f)
			randomNum = Random.Range (0, destinations.Length - 1);

		enemyAgent.destination = destinations[randomNum].position;
	}
}
