using UnityEngine;
using System.Collections;

public class WeaponGun : WeaponBase {

	public override void Start ()
	{
		base.Start ();
		AmmoGun.SendGun += AddAmmoToList;
	}
}
