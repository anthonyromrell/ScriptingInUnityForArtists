using UnityEngine;
using System.Collections;

public class DieDestroy : MonoBehaviour {
	

	public virtual void OnMouseEnter () 
	{
		StaticVars.gameScore++;
		Object.Destroy (this.gameObject);
	}
}
