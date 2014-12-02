using UnityEngine;
using System.Collections;

public class Die : MonoBehaviour {

	void OnMouseUp () 
	{
		Object.Destroy (this.gameObject);
	}

}
