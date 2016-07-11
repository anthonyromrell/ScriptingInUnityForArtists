using UnityEngine;
using System.Collections;

public class PowerUpBase : MonoBehaviour {

	public int power = 100;
	public int speed = 10;
	public int health = 5;

	public PowerUpInventory myInventory;

	void OnMouseUp () {
		myInventory.AddPowerUpToList (this);
		gameObject.SetActive (false);
	}

}
