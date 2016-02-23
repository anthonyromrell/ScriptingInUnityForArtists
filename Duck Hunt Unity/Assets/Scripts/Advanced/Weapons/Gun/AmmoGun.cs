using UnityEngine;
using System.Collections;
using System;

public class AmmoGun : AmmoBase {

	public static Action<AmmoBase> SendGun;
	// Use this for initialization
	public override void Start () {
		base.Start ();
		WeaponSPGun.SendSpawnPoint += AddSpawnPoint;
		if (SendGun != null)
			SendGun (this);
	}
}