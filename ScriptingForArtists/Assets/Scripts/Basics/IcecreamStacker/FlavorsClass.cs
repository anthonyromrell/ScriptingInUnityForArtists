using UnityEngine;
using System.Collections;

[System.Serializable]
public class FlavorsClass {
	//Needs to not be mono (it will be instanced in other scripts)
	//Needs to be serializable (Maybe)
	//String of the flavor names
	public string flavorName;
	//Int of bonus num
	public int flavorBonusValue;
}
