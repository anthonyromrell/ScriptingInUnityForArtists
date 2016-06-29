using UnityEngine;
using System.Collections;

public class ScoopClass : MonoBehaviour {

	int bonusPointsFromOrder;

	public int AddScoops (FlavorsClass _flavor){
		//Function that can
		//var of the number of scoops
		//We need to know the scoop flavors to add the scoops
		switch (_flavor.flavorName) {

		case ("Cherry"):
			print (_flavor.flavorName + " is avaliable");
					//a. Add Bonus Points for free sprinkles
			bonusPointsFromOrder += _flavor.flavorBonusValue;
			break;
		case ("Chocolate"):
			print (_flavor.flavorName + " is avaliable");
				//a. Add Bonus Points for free sprinkles
			bonusPointsFromOrder += _flavor.flavorBonusValue;
			break;
		case ("Vanilla"):
			print (_flavor.flavorName + " is avaliable");
				//a. Add Bonus Points for free sprinkles
			bonusPointsFromOrder += _flavor.flavorBonusValue;
			break;
		case ("Strawberry"):
			print (_flavor.flavorName + " is avaliable");
				//a. Add Bonus Points for free sprinkles
			bonusPointsFromOrder += _flavor.flavorBonusValue;
			break;
		case ("Banana"):
			print (_flavor.flavorName + " is avaliable");
				//a. Add Bonus Points for free sprinkles
			bonusPointsFromOrder += _flavor.flavorBonusValue;
			break;

		default:
			print ("We don't have " + _flavor.flavorName);
					//b. subract Bonus Points for free sprinkles
			bonusPointsFromOrder--;
			break;
		}

		//Return the scoops and flavors to the order class to complete
		return bonusPointsFromOrder;
	}
	
	//Needs to be on a gameObject with a collider

	//Instance Flavors class
	public FlavorsClass[] avaliableFlavors;

	void OnMouseDown () {
		foreach (FlavorsClass _flavor in avaliableFlavors) {
			print (_flavor.flavorName);
		}
	}

}
