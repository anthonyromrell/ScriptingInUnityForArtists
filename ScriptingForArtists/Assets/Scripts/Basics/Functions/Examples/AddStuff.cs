using UnityEngine;
using System.Collections;

public class AddStuff : MonoBehaviour {

	//Create 2 users
	public string user1;
	public string user2;

	//Create 1 bool
	public bool winnerBool;

	//Create a function
	void TestWhoWon (){
		//A. Test the bool with an if statement
		if (winnerBool) {
			//B. Test if user 1 wins
			print (user1+" WINNER");
		} else {
			//C. Test if user 2 wins
			print (user2+" WINNER");
		}
		//D. Print the winner
	}

	void Update (){
		TestWhoWon ();
	}

	//Public makes it visible in Unity
	public string username;//this can be changed in Unity

	void PrintUsername (){
		//this adds a string to the username.
		print (username + ", YOU WIN!!!");
	}
	//Create function
	//Job of the the function:
	void AddTwoFloats (float _i, float _j){//Pass the floats as arguments
		//Add two floats
		float finalValue= _i+_j;
		//Print the result
		print (finalValue);
	}
	
	// Use this for initialization
	void Start () {
		PrintUsername ();
	}
}
