using UnityEngine;
using System.Collections;

public class EndDuck : MonoBehaviour {

	public virtual void OnTriggerEnter (Collider _c)
	{
		Object.Destroy (_c.gameObject);
	}

}
