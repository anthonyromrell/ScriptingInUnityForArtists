using UnityEngine;
using System.Collections;
using System;

public class AddPatrolPoint : MonoBehaviour
{
		public static Action<Transform> SendTransformAsPoint;

		// Use this for initialization
		void Start ()
		{
				if (SendTransformAsPoint != null)
						SendTransformAsPoint (transform);
		}

}
