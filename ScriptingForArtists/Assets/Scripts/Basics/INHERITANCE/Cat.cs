using UnityEngine;
using System.Collections;

public class Cat : Animal{

	// Use this for initialization
	void Scratch ()
	{
		print ("Scratching");
		//this can attack mice, and breakdown chairs
	}
	
	void OnMouseDown()
	{
		Scratch ();
	}
}
