using UnityEngine;
using System.Collections;

public class WeaponBomb : WeaponBase {

	public override void Start ()
	{
		base.Start ();
		AmmoBomb.SendBomb += AddAmmoToList; 
	}
}
