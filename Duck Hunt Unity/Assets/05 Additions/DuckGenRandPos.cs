using UnityEngine;
using System.Collections;

public class DuckGenRandPos : Generator {

	public float maxRadomValue;
	public GameObject nextButton;

	public override void GenerateDuck ()
	{
		if(StaticVars.bullets > 0) {
			Vector3 newPos = new Vector3 ();
			newPos.x = Random.Range (maxRadomValue*-1, maxRadomValue);

			Object.Instantiate (newDuck, newPos, Quaternion.identity);
		} else {
			nextButton.SetActive(true);
		}
	}
}
