using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

[RequireComponent (typeof(NavMeshAgent))]

public class PatrolOrAttackDynamic: MonoBehaviour
{

		public Transform playerOne;
		private List<Transform> patrolPoints;
		NavMeshAgent enemyAgent;
		int currentPatrolPoint = 0;

		Action CanPatrol;
		Action CanAttack;

		void Patrolling ()
		{
				if (patrolPoints.Count == 0)
						return;
				
				enemyAgent.destination = patrolPoints [currentPatrolPoint].position;
				currentPatrolPoint = UnityEngine.Random.Range (0, patrolPoints.Count - 1);
		}

		public void StopPatrolling ()
		{
				CanPatrol -= Patrolling;
				CanAttack += Attacking;
				enemyAgent.speed = 7;
		}

		void Attacking ()
		{
				enemyAgent.destination = playerOne.position;
		}

		void Update ()
		{
				if (enemyAgent.remainingDistance < 0.5f) {
						if (CanPatrol != null)
								CanPatrol ();
				}

				if (CanAttack != null)
						CanAttack ();
		}

		public void AddPoint (Transform _point)
		{
				patrolPoints.Add (_point);
		}

		void Start ()
		{
				patrolPoints = new List<Transform> ();
				AddPatrolPoint.SendTransformAsPoint += AddPoint;
				enemyAgent = GetComponent<NavMeshAgent> ();
				CanPatrol += Patrolling;
		}
}