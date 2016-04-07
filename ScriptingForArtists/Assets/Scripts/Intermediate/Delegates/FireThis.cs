using UnityEngine;
using System.Collections;

public class FireThis : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StaticAction.ActionCall += Fire;
	}
	
	// Update is called once per frame
	void Fire () {
		print ("Fired from this script " + this.name);
	}
}
