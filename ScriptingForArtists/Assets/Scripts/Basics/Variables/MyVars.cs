using UnityEngine;
using System.Collections;

public class MyVars : MonoBehaviour {

	int myInt = 0;

	// Use this for initialization
	void Start () {
		print (myInt);
		myInt = 10;
		print (myInt);
		myInt += 10;
		print (myInt);
		myInt -= 5;
		print (myInt);
		myInt = 2;
		print (myInt);
	}

}
