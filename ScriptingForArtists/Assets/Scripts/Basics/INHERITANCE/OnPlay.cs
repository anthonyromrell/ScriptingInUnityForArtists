using UnityEngine;
using System.Collections;
using System;

public class OnPlay : MonoBehaviour {

	public static Action CallPlay;

	void OnMouseDown ()

	{
		if (CallPlay != null)
			CallPlay ();
	}
}
