using UnityEngine;
using System.Collections;

public class DieFall : DieDestroy {

	public Fly flyS;
	public Fall fallS;

	public override void OnMouseEnter () 
	{
		StaticVars.gameScore++;
		flyS.enabled = false;
		fallS.enabled = true;
	}
}
