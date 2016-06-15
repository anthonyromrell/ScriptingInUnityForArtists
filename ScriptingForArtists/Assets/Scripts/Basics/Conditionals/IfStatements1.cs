using UnityEngine;
using System.Collections;

public class IfStatements1 : MonoBehaviour {

	bool myBool = true;
	public int myInt = 1;
	const int myCInt = 1;
	public string myString;
	const string myConst = "OU812";

	// Update is called once per frame
	void Update () {
		if (myString == myConst)
			print ("That's correct, you have unlocked Health PowerUps");
		else
			print (false);
	}
}
