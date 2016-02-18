using UnityEngine;
using System.Collections;
using System;

public class DiceSide : MonoBehaviour {

	public static Action<int> SendDiceNum;

	public int diceNumAfterRoll;

	void DiceActionCall (int _diceNum) {
		print (_diceNum);
		SendDiceNum (_diceNum);
	}
	
	IEnumerator ReturnDiceNum (string _diceNumAsString) {

		yield return new WaitForSeconds (1);

		switch (_diceNumAsString) {
		case "1":
			DiceActionCall(6);
			break;
		case "2":
			DiceActionCall(5);
			break;
		case "3":
			DiceActionCall(4);
			break;
		case "4":
			DiceActionCall(3);
			break;
		case "5":
			DiceActionCall(2);
			break;
		case "6":
			DiceActionCall(1);
			break;
		}
	}

	void OnTriggerEnter () {
		StartCoroutine(ReturnDiceNum(this.name));
		print ("Enter");
	}

	void OnTriggerExit () {
		print ("Exit");
		StopAllCoroutines ();
	}

}
