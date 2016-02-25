using UnityEngine;
using System.Collections;
using System;

[RequireComponent(typeof(NavMeshAgent))]

public class RandomAiPatrol : MonoBehaviour {

		public Transform[] patrolPoints;
		NavMeshAgent enemyAgent;
		int currentPatrolPoint = 0;

		Action CanPatrol;

		void Patrolling() {
				if (patrolPoints.Length == 0)
						return;
				enemyAgent.destination = patrolPoints [currentPatrolPoint].position;

				currentPatrolPoint = UnityEngine.Random.Range (0, patrolPoints.Length-1);
		}
				
		void Update () {
				if (enemyAgent.remainingDistance < 0.5f) {
						if(CanPatrol != null)
								CanPatrol();
				}
		}

		void Start () {
				enemyAgent = GetComponent<NavMeshAgent> ();
				CanPatrol += Patrolling;
		}
}