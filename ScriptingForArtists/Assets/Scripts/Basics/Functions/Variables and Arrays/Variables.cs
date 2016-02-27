using UnityEngine;
using System.Collections;

public class Variables : MonoBehaviour {

	//public is accessible in Unity Editor and other scripts
	public int myInt = 0;
	//Private is only accessible to the script
	private string myString;
	//also private
	int privateInt;

	//Other common datatypes
	public float myFloat;
	public Vector3 myVector3;

	//Common for Unity
	public Transform myTransform;
	public GameObject myGameObject;

	void Start () {
		//used to configure the component automatically
		myTransform = GetComponent<Transform> ();
	}
	//this class can be used at a component or instance
	//Static variables can't be instanced
}
