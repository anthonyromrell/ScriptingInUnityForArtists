using UnityEngine;
using System.Collections;

public class LazerLength : MonoBehaviour {

	public Transform endPoint;
	Vector3 tempScale;

	// Update is called once per frame
	void Update () {
		tempScale.x = Vector3.Distance (transform.position, endPoint.position);
		tempScale.y = 1;
		tempScale.z = 1;
		transform.localScale = tempScale;
	}
}
