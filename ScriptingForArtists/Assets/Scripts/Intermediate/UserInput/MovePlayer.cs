using UnityEngine;
using System.Collections;

public class MovePlayer : MonoBehaviour {

	Vector3 pos;

	public float speed = 10;
	
	void Move ()
	{
		//Move character in X using the arrow key
		pos.x = Input.GetAxis ("Horizontal")*Time.deltaTime*speed;
		transform.Translate (pos);
	}

	// Update is called once per frame
	void Update () {
		Move ();
	}
}
