using UnityEngine;
using System.Collections;

public class MyLoops : MonoBehaviour {

	//Add the names in Unity
	public string[] myFamily;
	string familyArray;

	// Use this for initialization
	void Start () {
		foreach (string _familyName in myFamily) {
			familyArray = (_familyName+" Loves me");
			print (familyArray);
		}
	}
}
