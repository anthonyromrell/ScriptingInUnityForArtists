using UnityEngine;
using System.Collections;

public class EndDuckPlus : EndDuck {

	public Animator dogAnims;
	public string dogAnimState = "miss";

	public override void OnTriggerEnter (Collider _c)
	{
		base.OnTriggerEnter(_c);
		dogAnims.SetBool (dogAnimState, true);
	}

}
