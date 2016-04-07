using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EndGame : MonoBehaviour {

	float health = 1;
	public Transform healthBar;
	Vector3 healthScale;

	IEnumerator EndThisGame ()
	{
		yield return new WaitForSeconds (1);
		Application.LoadLevel ("EndGame");
	}

	void OnMouseDown () {
		health -= 0.1f;
		healthScale.x = health;
		healthBar.localScale = healthScale;

		if (health > 0)
			return;

		StartCoroutine (EndThisGame ());
		healthBar.gameObject.SetActive (false);
	}

	void Start () {
		healthScale.y = 1;
		healthScale.z = 1;
	}
}
