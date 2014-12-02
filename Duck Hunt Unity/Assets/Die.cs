using UnityEngine;
using System.Collections;

public class Die : MonoBehaviour {

	void OnMouseDown () 
	{
		StaticVars.gameScore++;
		Object.Destroy (this.gameObject);
	}

}
