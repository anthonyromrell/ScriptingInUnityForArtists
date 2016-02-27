using UnityEngine;
using System.Collections;

public class DiceForce : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody> ().AddExplosionForce (Random.Range(200, 600), Vector3.left, 100);
	}

}
