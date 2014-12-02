using UnityEngine;
using System.Collections;

public class ResetDog : MonoBehaviour {

	public Animator dogAnims;

	void ResetTheDog () {
		dogAnims.SetBool ("hit", false);
		dogAnims.SetBool ("miss", false);
	}
}
