using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using ArtisanDream;
using ArtisanDream.PlayerClasses;

public class MyLists : MonoBehaviour {

	public List<string> playerNames = new List<string>();
	public Text myInputText;
	public string output;


	void OnMouseUp () {
		playerNames.Add (myInputText.text);
	}
}
