using UnityEngine;
using System.Collections;
using System;

[RequireComponent(typeof(Rigidbody))]

public class AmmoBase : MonoBehaviour {

	public 	Transform ammoSpawnPoint;
	public static Action<AmmoBase> SendAmmo;
	Rigidbody ammoRigidBody;

	void AddSpawnPoint (Transform obj)
	{
		ammoSpawnPoint = obj;
	}

	public virtual void Start () {
		SpawnPoint.SendSpawnPoint += AddSpawnPoint;
		ammoRigidBody = GetComponent<Rigidbody> ();
		ammoRigidBody.useGravity = false;
	}

	public void FireAmmo () {
		ammoRigidBody.Sleep ();
		ammoRigidBody.transform.position = ammoSpawnPoint.position;
		ammoRigidBody.AddExplosionForce (200, Vector3.forward, 100);
	}

}
