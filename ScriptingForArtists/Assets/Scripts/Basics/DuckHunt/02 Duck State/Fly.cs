using UnityEngine;
using System.Collections;

public class Fly : FlySimple{

	private float altDirection;
	public bool flightDirection = false;

	void ChangeDirection ()
	{
		if (flightDirection) {
			altDirection = flightSpeed;
		}
		else {
			altDirection = flightSpeed * -1;
		}
	}
	
	void ResetFlightDirection ()
	{
		flightDirection = (Random.value < 0.5);
		ChangeDirection ();
	}

	void Start () {
		ResetFlightDirection ();
	}


	public override void ChangeFlightPosition ()
	{
		transform.position += new Vector3 (altDirection, flightSpeed, 0);
	}

	void Update () {
		ChangeFlightPosition ();
	}

	void OnTriggerEnter () 
	{
		ResetFlightDirection ();
	}
}
