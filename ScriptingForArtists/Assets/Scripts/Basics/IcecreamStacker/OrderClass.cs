using UnityEngine;
using System.Collections;

public class OrderClass : MonoBehaviour {

	//Needs to run
	//1. cube with a box collider
	//2. This script as a component on the cube

	//var that take the order of scoops from the editor
	public FlavorsClass[] myOrder;

	public ScoopClass myScoopAdder;

	void OrderReady (){
		//print the order
	}

	//OnMouseDown Event is used
	void OnMouseDown () {
		//Function that processes the order by adding the number of scoops
		//Will reference the Scoop Class to process the order
		//We need to know the scoop flavors with the number of scoops

		//Is Called at the end of the process function
		//Function that completes the order and tells the buyer it's finished
	}
	//If bonus number is reached, user can add sprinkles for free
	//Function that activates sprinkles

}
