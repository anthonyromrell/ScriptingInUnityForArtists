using UnityEngine;
using System.Collections;

public class HealthDamage : MonoBehaviour {

	public Multiplayer mP;

	// Use this for initialization
	void OnMouseDown () {
		foreach (HealthData _hd in mP.players) {
			if(_hd.username == this.name) {
				print (_hd.TakeDownDefense()+" "+_hd.username);
			}
		}
	}

}
