using UnityEngine;
using System.Collections;

public class LazerLookAt : MonoBehaviour {

	public Transform point;

	// Update is called once per frame
	void Update () {
		transform.LookAt (point);
	}
}
