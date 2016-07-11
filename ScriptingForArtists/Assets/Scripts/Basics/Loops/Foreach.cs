using UnityEngine;
using System.Collections;

public class Foreach : MonoBehaviour {

	public string[] playerNames;
	public string search;

	// Use this for initialization
	void Start () {
		foreach (string _name in playerNames) {
			if(_name == search)
				print (_name);
		}
	}
}