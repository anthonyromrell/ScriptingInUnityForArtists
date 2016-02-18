using UnityEngine;
using System.Collections;

public class Functions : MonoBehaviour {

	void VoidFunction (){//Void is a function with no return value
		print (null);
	}
	void FunctionWithParameters (string _string) {//_string is the parameter
		print (_string);
	}

	int FunctionReturnsAnInt () {//When called this returns a value
		return 10;
	}

	int FunctionReturnsWithParameter (int _int) {
		return _int + 10;//returns an equation
	}

	// Use this for initialization
	void Start () { //Unity MonoBehaviour runs once
		print ("Will run on Start");
		VoidFunction ();
		FunctionWithParameters ("This is the String");
		int myInt = FunctionReturnsAnInt ();
		print (myInt);
		myInt = FunctionReturnsWithParameter (6);
		print (myInt);
	}
	
	// Update is called once per frame
	void Update () {//Unity Monobehaviour runs every frame
		print ("Will run on Update");
	}

}
