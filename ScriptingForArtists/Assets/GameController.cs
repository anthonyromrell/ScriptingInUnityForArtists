using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public int newBullets = 10;


	// Use this for initialization
	void Start () {
		StaticVars.bullets = newBullets;	
	}
}
