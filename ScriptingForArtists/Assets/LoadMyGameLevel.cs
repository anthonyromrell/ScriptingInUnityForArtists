using UnityEngine;
using System.Collections;

public class LoadMyGameLevel : MonoBehaviour {

	public string levelToLoad;

	public void OnMouseUp () {
		Application.LoadLevel (levelToLoad);
	}

}
