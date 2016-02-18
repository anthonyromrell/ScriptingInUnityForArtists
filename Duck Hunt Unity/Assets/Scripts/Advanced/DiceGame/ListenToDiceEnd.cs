using UnityEngine;
using System.Collections;

public class ListenToDiceEnd : MonoBehaviour {

	public int thisNum = 1;

	IEnumerator RotateThis () {
		yield return new WaitForSeconds (0.1f);
		transform.Rotate (0, 45, 0);
		print (thisNum);
	}

	void OnDiceEnd (int i) {
		if(i == thisNum)
			StartCoroutine (RotateThis ());
	}

	void Start () {
		DiceSide.SendDiceNum += OnDiceEnd;
	}
}
