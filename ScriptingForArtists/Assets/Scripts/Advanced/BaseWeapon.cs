using UnityEngine;
using System.Collections;

public class BaseWeapon : MonoBehaviour {
	
	public BaseAmmo thisAmmo;

	// Update is called once per frame
	void Update () {
		thisAmmo.Fire ();
	}
}
