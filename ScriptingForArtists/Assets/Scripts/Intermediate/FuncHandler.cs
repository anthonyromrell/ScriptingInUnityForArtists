using UnityEngine;
using System.Collections;

public class FuncHandler : MonoBehaviour {

	int PassIntToo ()
	{
		return 8;
	}

	// Use this for initialization
	void Start () {
		Funcs.PassInt += PassIntToo;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
