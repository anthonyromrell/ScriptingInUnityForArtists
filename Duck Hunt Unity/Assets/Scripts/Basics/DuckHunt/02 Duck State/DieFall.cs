using UnityEngine;
using System.Collections;

public class DieFall : DieDestroy {

	public Fly flyS;
	public Fall fallS;


	public override void OnMouseEnter () 
	{
		StaticVars.gameScore++;
		if (StaticVars.bullets > 0) {
			StaticVars.bullets--;
			flyS.enabled = false;
			fallS.enabled = true;
		}
	}
}
