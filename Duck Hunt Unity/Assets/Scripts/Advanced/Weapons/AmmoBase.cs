using UnityEngine;
using System.Collections;
using System;

public class AmmoBase : MonoBehaviour {

	public int distance = 1000;

	public static Action<AmmoBase> AddThisToWeaponList;	

	IEnumerator FireToDistance () {
		print ("FIRE");
		while (distance > 0) {
			distance--;
			print (distance);
			yield return new WaitForSeconds(0.5f);
		}
	}

	public void FireAmmo () {
		StartCoroutine (FireToDistance());
	}

	// Use this for initialization
	void Start () {
		AddThisToWeaponList (this);
	}
}
