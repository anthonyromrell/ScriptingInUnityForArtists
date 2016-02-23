using UnityEngine;
using System.Collections;
using System;

public class SetThisAsSpawnPoint : MonoBehaviour {

	public static Action<Transform> PassTransformAsSpawnPoint;

	void Start () {
		if (PassTransformAsSpawnPoint != null)
			PassTransformAsSpawnPoint (transform);
	}
}
