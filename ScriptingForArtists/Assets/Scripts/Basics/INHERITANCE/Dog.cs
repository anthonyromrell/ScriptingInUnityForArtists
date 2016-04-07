using UnityEngine;
using System.Collections;

public class Dog : Animal {

	void Bark ()
	{
		print ("Barking");
		//makes a sound, and scares cats
	}
	
	void OnMouseDown ()
	{
		Bark ();
	}

}
