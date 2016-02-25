using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	Vector3 moveDirection;
	public float speed = 10;
	CharacterController cc;

	void Start () {
		cc = GetComponent<CharacterController> ();
		MoveUsingArrowKeys.MoveOnArrows += Move;
		//MoveUsingButtons.Forward += Move;

		MoveUsingArrowKeys.RotateOnArrows += Rotate;
		//MoveUsingButtons.Rotate += Rotate;
	}

	void Rotate (float _rotateInY)
	{
		transform.Rotate (0, _rotateInY, 0);
	}

	void Move (float _moveInZ) {
		moveDirection.z = _moveInZ;
		moveDirection = transform.TransformDirection (moveDirection*speed*Time.deltaTime);
		cc.Move (moveDirection);
	}
}
