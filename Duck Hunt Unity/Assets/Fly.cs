using UnityEngine;
using System.Collections;

public class Fly : MonoBehaviour {

	public float flightSpeed = 0.05f;
	private float altDirection;
	public bool flightDirection = false;

	// Use this for initialization
	void Start () {
		flightDirection = (Random.value < 0.5);
	}
	
	// Update is called once per frame
	void Update () {
		if (flightDirection) {
			altDirection = flightSpeed;
		} else {
			altDirection = flightSpeed*-1;
		}

		transform.position += new Vector3 (altDirection,flightSpeed,0);
	}
}
