using UnityEngine;
using System.Collections;

public class MoveForwardInZ : MonoBehaviour {

	float speed = 10;
	Vector3 pos;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		pos.z = speed*Time.time;
		transform.position = pos;
	}
}
