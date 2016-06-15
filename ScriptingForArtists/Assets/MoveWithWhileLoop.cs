using UnityEngine;
using System.Collections;

public class MoveWithWhileLoop : MonoBehaviour {

	public float xDistance = 0;
	Vector3 pos;

	IEnumerator MoveInX () {
		while (pos.x <= xDistance) {
			pos.x += 0.1f;
			print ("WhileLoop");
			transform.position = pos;
			yield return new WaitForSeconds (0.1f);
		}
	}
	
	void OnMouseDown () {
		xDistance += 1;
		StartCoroutine (MoveInX ());
	}	
}
