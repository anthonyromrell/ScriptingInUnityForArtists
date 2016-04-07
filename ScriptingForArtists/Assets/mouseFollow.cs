using UnityEngine;
using System.Collections;

public class mouseFollow : MonoBehaviour {

	float speed = 10;

	Vector3 v3;
	
	// Update is called once per frame
	void Update () {

		v3 = Input.mousePosition;
		v3.z = (speed*Time.time)-10;
		v3 = Camera.main.ScreenToWorldPoint(v3);

		transform.position = v3;
	}
}
