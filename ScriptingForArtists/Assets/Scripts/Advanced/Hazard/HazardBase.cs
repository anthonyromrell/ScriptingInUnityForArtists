using UnityEngine;
using System.Collections;
using System;

public class HazardBase : MonoBehaviour {

	public static Action<float, float> SendHazard;
	public static Action RestoreFromHazard;

	public float hazardOne = 5;
	public float hazardTwo = 0.1f;

	void OnTriggerEnter()
	{
		if (SendHazard != null)
			SendHazard (hazardOne, hazardTwo);
	}

	void OnTriggerExit ()
	{
		if (RestoreFromHazard != null)
						RestoreFromHazard ();
	}

}
