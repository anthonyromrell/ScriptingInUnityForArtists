using UnityEngine;
using System.Collections;
using System;

[RequireComponent(typeof(Rigidbody))]

public class AmmoBase : MonoBehaviour {

	public Transform ammoSpawnPoint;
	//public static Action<AmmoBase> SendAmmo;
	Rigidbody ammoRigidBody;

	public void AddSpawnPoint (Transform obj)
	{
		ammoSpawnPoint = obj;
	}

	public virtual void Start () {
		ammoRigidBody = GetComponent<Rigidbody> ();
		ammoRigidBody.useGravity = false;
	}

	public void FireAmmo () {
		ammoRigidBody.Sleep ();
		ammoRigidBody.transform.position = ammoSpawnPoint.position;
		ammoRigidBody.AddExplosionForce (200, Vector3.forward, 100);
	}

}
