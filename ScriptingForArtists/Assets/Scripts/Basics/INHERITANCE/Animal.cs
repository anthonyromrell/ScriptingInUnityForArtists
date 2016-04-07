using UnityEngine;
using System.Collections;

public class Animal : MonoBehaviour {

	public int energy = 100;
	public int health = 100;
	public int points = 0;


	//All animals eat on start
	protected void Start () {
		Eat ();
		OnPlay.CallPlay += Play;
	}

	protected void Eat () 
	{
		print (this.name + " is eating");
		//process food
	}

	protected void Sleep () 
	{
		//run calc time sleeping x energy
	}

	protected void Play ()
	{
		print (this.name + " is playing");
		//subtract energy
		//add points
	}

}
