using UnityEngine;
using System.Collections;

public class HealThis : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StaticAction.ActionCall += Heal;
	}
	
	// Update is called once per frame
	void Heal () {
		print ("This is now healing "+this.name);
	}
}
