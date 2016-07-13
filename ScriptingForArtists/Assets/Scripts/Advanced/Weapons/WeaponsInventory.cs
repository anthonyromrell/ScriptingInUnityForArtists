using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using ArtisanDream;

namespace ArtisanDream {
public class WeaponsInventory : MonoBehaviour {

		public List<WeaponBase> myWeapons = new List<WeaponBase>();

		void Update () {
			if (Input.GetKeyUp (KeyCode.R) && myWeapons.Count > 0) {
				myWeapons[0].gameObject.SetActive(true);
				myWeapons.RemoveAt (0);
			}

			if (Input.GetKeyUp (KeyCode.F) && myWeapons.Count > 0 && myWeapons [0].ammoCount > 0) {
				print ("BANG");
				myWeapons [0].ammoCount--;
			} else if (Input.GetKeyUp (KeyCode.F) && myWeapons.Count > 0) {
				myWeapons.RemoveAt (0);
			}
		}

	}
}
