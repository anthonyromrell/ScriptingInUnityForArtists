using UnityEngine;
using System.Collections;

public class Die : MonoBehaviour {

	public Fly flyS;
	public Fall fallS;

	void OnMouseEnter () 
	{
		StaticVars.gameScore++;
		flyS.enabled = false;
		fallS.enabled = true;
	}
}
