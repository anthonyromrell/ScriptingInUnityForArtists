using UnityEngine;
using System.Collections;

public class Multiplayer : MonoBehaviour {

	public HealthData[] players;

	void Start () {
		foreach (HealthData _hd in players) {
			print (_hd.username+" "+_hd.strength);
			print (_hd.TakeDownDefense());
			print (_hd.TakeDownDefense());
		}
	}
}
