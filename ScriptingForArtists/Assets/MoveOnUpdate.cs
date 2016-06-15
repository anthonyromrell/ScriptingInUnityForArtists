using UnityEngine;
using System.Collections;

public class MoveOnUpdate : MonoBehaviour {
				
	// Update is called once per frame
	void Update () {
		if(transform.position.x <= 10)
			transform.Translate (0.1f,0,0);

		print ("Update");
	}
}
