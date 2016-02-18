using UnityEngine;
using System.Collections;
using System;

public class AmmoBomb : AmmoBase {

	public static Action<AmmoBomb> SendBomb;

	public override void Start ()
	{
		base.Start ();
		if (SendBomb != null)
			SendBomb (this);
	}

}
