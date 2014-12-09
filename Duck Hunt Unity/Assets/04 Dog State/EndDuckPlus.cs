using UnityEngine;
using System.Collections;

public class EndDuckPlus : EndDuck {

	public Animator dogAnims;
	public GameObject dogGO;
	public string dogAnimState = "miss";

	public override void OnTriggerEnter (Collider _c)
	{
		base.OnTriggerEnter(_c);

		Vector3 vect = new Vector3 ();
		Vector3 newVect = _c.ClosestPointOnBounds (vect);
		newVect.y = 0;
		dogGO.transform.position = newVect;

		dogAnims.SetBool (dogAnimState, true);
	}
}
