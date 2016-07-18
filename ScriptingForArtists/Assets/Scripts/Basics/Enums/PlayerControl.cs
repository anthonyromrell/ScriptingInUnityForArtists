using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {
	
	public float healthTimer = 0;
	public float maxTime = 30;

	// Update is called once per frame
	void Update () {
		switch (MyEnums.gameState){
		case MyEnums.gameStates.Attacked:
			if (healthTimer < maxTime) {
				print (healthTimer);
				healthTimer = Time.time;
			} else {
				MyEnums.gameState = MyEnums.gameStates.Dying;
				this.gameObject.SetActive(false);
			}
			break;
		}
	}
}
