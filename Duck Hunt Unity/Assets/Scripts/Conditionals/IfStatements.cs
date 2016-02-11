using UnityEngine;
using System.Collections;

public class IfStatements : MonoBehaviour {

	public int myInt = 1;

	// Use this for initialization
	void Start () {
		if (0 == 1)//tests if true
			print (0);//if true this will run (hint, it's not true)

		if (myInt == 1)
			print ("True");//this will run if the value is 1

		if (myInt == 0) //only tests if true or false
			print ("true");
		else //this is used as an alternative to being true
			print ("false");
	}
}
