using UnityEngine;
using System.Collections;

public class FlySimple : MonoBehaviour {

	public float flightSpeed = 0.04f;
	
	public virtual void ChangeFlightPosition ()
	{
		transform.position += new Vector3 (0, flightSpeed, 0);
	}

	void Update () {
		ChangeFlightPosition ();
	}
}
