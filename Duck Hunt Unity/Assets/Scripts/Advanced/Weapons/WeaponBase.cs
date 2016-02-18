using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class WeaponBase : MonoBehaviour {
	
	public List<AmmoBase> AmmoBaseList;

	void HandleAddToWeapon (AmmoBase _ammoBase)
	{
		AmmoBaseList.Add (_ammoBase);
	}

	// Use this for initialization
	void Start () {
		AmmoBaseList = new List<AmmoBase> ();
		AmmoBase.AddThisToWeaponList += HandleAddToWeapon;
	}
	
	// Update is called once per frame
	void OnMouseDown () {
		print ("hey");
		AmmoBaseList [0].FireAmmo ();
	}
}
