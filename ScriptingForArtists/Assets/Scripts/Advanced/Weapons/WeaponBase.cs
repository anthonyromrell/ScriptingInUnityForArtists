using UnityEngine;
using System.Collections;
using ArtisanDream;

namespace ArtisanDream {
	public class WeaponBase : MonoBehaviour {
	
		public WeaponsInventory myWeaponsInventory;

		//Weapon Name is the GameObject Name
		public int firePower;
		public int ammoCount;

		void OnMouseUp () {
			if (myWeaponsInventory.myWeapons.Count < 2) {
				myWeaponsInventory.myWeapons.Add (this);
				gameObject.SetActive (false);
			}
		}
	
	}
}
