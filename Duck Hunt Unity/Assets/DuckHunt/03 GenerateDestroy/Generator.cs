using UnityEngine;
using System.Collections;

public class Generator : MonoBehaviour {

	public float nextTime = 2;
	public float currentTime = 0;
	public GameObject newDuck;

	public virtual void GenerateDuck ()
	{
		Object.Instantiate (newDuck);
	}

	void Update () {
		if (currentTime <= Time.time) {
			currentTime = Time.time + nextTime;
			GenerateDuck ();
		}
	}
}
