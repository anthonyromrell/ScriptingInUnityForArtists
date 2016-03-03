using UnityEngine;
using System.Collections;
using System;

[RequireComponent(typeof(NavMeshAgent))]

public class PatrolOrAttack : MonoBehaviour {

	public Transform playerOne;
	public Transform[] patrolPoints;
	NavMeshAgent enemyAgent;
	int currentPatrolPoint = 0;

	Action CanPatrol;
	Action CanAttack;

	void Patrolling() {
		if (patrolPoints.Length == 0)
			return;
		enemyAgent.destination = patrolPoints [currentPatrolPoint].position;

		currentPatrolPoint = UnityEngine.Random.Range (0, patrolPoints.Length-1);

		//currentPatrolPoint = (currentPatrolPoint + 1) % patrolPoints.Length;
	}

	public void StopPatrolling () {
		CanPatrol -= Patrolling;
		CanAttack += Attacking;
		enemyAgent.speed = 7;
	}

	void Attacking ()
	{
		enemyAgent.destination = playerOne.position;
	}
	
	void Update () {
		if (enemyAgent.remainingDistance < 0.5f) {
			if(CanPatrol != null)
				CanPatrol();
		}

		if (CanAttack != null)
			CanAttack ();
	}

	void Start () {
		enemyAgent = GetComponent<NavMeshAgent> ();
		CanPatrol += Patrolling;
	}
}