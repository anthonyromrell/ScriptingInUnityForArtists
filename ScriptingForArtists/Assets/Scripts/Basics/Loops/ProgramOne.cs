using UnityEngine;
using System.Collections;

public class ProgramOne : MonoBehaviour {
	/*
	 * Design a Program like this:
	 * Function: Choose two numbers and an Operator in Unity.  The Program uses an if statement to determine
	 * the solution and then prints it.
	 */

	public enum MyOperations { ADD, SUBTRACT, MULTIPLY, DIVIDE, SQUARE }; 

	public MyOperations currentOperation;

	public int num_one;
	public int num_two;

	int ChangeOperation (int _one, int _two) {
		int value = 0;
		switch (currentOperation) {
		case MyOperations.ADD:
			value = _one+_two;
			break;
		case MyOperations.SUBTRACT:
			value = _one-_two;
			break;
		case MyOperations.MULTIPLY:
			value = _one*_two;
			break;
		case MyOperations.DIVIDE:
			if(_two != 0)
				value = _one/_two;
			break;
		case MyOperations.SQUARE:
			value = (_one+_two)*(_one+_two);
			break;
		}
		return value;
	}

	void OnMouseDown (){
		int finalValue = ChangeOperation (num_one, num_two);
		print (finalValue);
	}
}
