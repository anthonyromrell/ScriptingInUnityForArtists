using UnityEngine;

public class StaticVariables {
	//Static vars are accessed directly to a script
	//They are not instanced or used and a Unity component
	//static vars must be public
	public static int staticInt = 10;
	public static string staticString = "Dog";
	//must include "using UnityEngine;"
	public static GameObject staticGameObject;
}