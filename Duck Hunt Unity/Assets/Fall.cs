using UnityEngine;
using System.Collections;

public class Fall : MonoBehaviour {

	public float fallSpeed = 0.4f;

	void Update () {
		transform.position += new Vector3 (0,-fallSpeed,0);
	}

	void OnTriggerEnter (Collider _c) 
	{
		if (_c.tag == "DuckEnder") {
			Object.Destroy(this.gameObject);		
		}
	}
}
