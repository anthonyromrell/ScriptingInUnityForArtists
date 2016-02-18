using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class WeaponBase : MonoBehaviour {

	public int ammoRounds = 10;

	private List<AmmoBase> weaponAmmo;

	void AddAmmoToList (AmmoBase _ammobase) {
		weaponAmmo.Add (_ammobase);
		print (weaponAmmo.Count);
	}

	int i = 0;

	void RecycleAmmo ()
	{
		if (i < weaponAmmo.Count) {
						weaponAmmo[i].FireAmmo();
						i++;
				} else {
						i = 0;
			}
	}

	void Fire ( ) {
		if (ammoRounds > 0) {
						print ("Fire");
						ammoRounds--;
						RecycleAmmo();
		
				} else {
						print ("Out");
				}
	}

	void OnMouseDown () {
		Fire ();
	}

	void Start () {
		weaponAmmo = new List<AmmoBase> ();
		AmmoBase.SendAmmo += AddAmmoToList;
	}
}
