using UnityEngine;
using System.Collections;

public class EndDuckPlusMoveDog : EndDuckPlus {
	
	public override void OnTriggerEnter (Collider _c)
	{
		base.OnTriggerEnter(_c);

		Vector3 vect = new Vector3 ();
		Vector3 newVect = _c.ClosestPointOnBounds (vect);
		newVect.y = 0;
		dogGO.transform.position = newVect;

	}
}
