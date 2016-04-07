using UnityEngine;
using System.Collections;
using System;

public class MyAction : MonoBehaviour {

	Action ThisAction;

	void OnEnable ()
	{
		ThisAction = Fire;
		ThisAction ();
	}

	void OnDisable ()
	{
		ThisAction -= Fire;
		ThisAction = Heal;
		ThisAction += AddAmmo;
		ThisAction ();
	}

	void Fire()
	{
		print ("Fire");
	}

	void Heal()
	{
		print ("Heal");
	}

	void AddAmmo ()
	{
		print ("Add Ammo");
	}

}
