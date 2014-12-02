using UnityEngine;
using System.Collections;

public class Fly : MonoBehaviour {

	public float flightSpeed = 0.05f;
	private float altDirection;
	public bool flightDirection = false;

	void ResetFlightDirection ()
	{
		flightDirection = (Random.value < 0.5);
		ChangeDirection ();
	}

	void Start () {
		ResetFlightDirection ();
	}

	void ChangeDirection ()
	{
		if (flightDirection) {
			altDirection = flightSpeed;
		}
		else {
			altDirection = flightSpeed * -1;
		}
	}

	void Update () {
		transform.position += new Vector3 (altDirection,flightSpeed,0);
	}

//	void OnTriggerEnter () 
//	{
//		ResetFlightDirection ();
//	}
}
