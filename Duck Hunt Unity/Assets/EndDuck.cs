using UnityEngine;
using System.Collections;

public class EndDuck : MonoBehaviour {

	void OnTriggerEnter (Collider _c)
	{
		Object.Destroy (_c.gameObject);
	}

}
