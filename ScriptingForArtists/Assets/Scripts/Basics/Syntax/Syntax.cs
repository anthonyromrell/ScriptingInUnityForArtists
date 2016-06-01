using UnityEngine;
using System.Collections;

public class Syntax : MonoBehaviour {

	int myInt = 5;

	int MyInt (int _i, int _j) {
		return _i + _j;
	}

	int MyIntBy2 (int _i) {
		int _k = (_i + 10)*2;
		return _k;
	}

	int MyIntNoArgs () {
		return 8 + 9 * 10;
	}

	void Start () {
		myInt = MyIntNoArgs (8, 800);
		print (myInt);
		myInt = MyIntBy2 (10);
		print (myInt);
		myInt = MyIntNoArgs();
		print (myInt);
		myInt = MyInt (45, 35);
		print (myInt);
		myInt = 89;
	}
}