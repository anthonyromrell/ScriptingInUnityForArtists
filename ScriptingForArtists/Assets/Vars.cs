using UnityEngine;
using System.Collections;

public class Vars : MonoBehaviour {
	
	int jelly = 1;
	int honey = 5;
	int peanutButter = 3;

	float jellyJar = 0.5f;
	float honeyJar = 1.7f;
	float peanutButterJar = 3.987f;

	string jellyFlavor = "Grape";
	string honeyFlavor = "Clover";
	string peanutButterStyle = "Crunchy";

	int MixIngredients (int ingredient1){
		return ingredient1;
	}

	int MixIngredients (int ingredient1, int ingredient2){
		return ingredient1+ingredient2;
	}

	int MixIngredients (int ingredient1, int ingredient2, int ingredient3){
		return ingredient1+ingredient2+ingredient3;
	}

	void Start () {
		print (peanutButterStyle + MixIngredients (peanutButter));
		print (jellyFlavor + MixIngredients (peanutButter, jelly));
		print (honeyFlavor + MixIngredients (peanutButter,jelly, honey));
	}
}
