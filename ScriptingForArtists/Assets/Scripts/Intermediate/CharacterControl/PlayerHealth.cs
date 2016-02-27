using UnityEngine;
using System.Collections;

[RequireComponent(typeof(PlayerMovement))]

public class PlayerHealth : MonoBehaviour {

	PlayerMovement player;
	float playerOriginalSpeed;
	float health = 1;
	
	IEnumerator HealthDecay (float _decayRate) 
	{
		while (health > 0) 
		{
			yield return new WaitForSeconds (_decayRate*5);
			health -= _decayRate;
			print (health);
		}
		print ("Dead");
		player.StopMoving ();
	}

	void SendHazardHandler (float _newSpeed, float _decayRate)
	{
		playerOriginalSpeed = player.speed;
		player.speed = _newSpeed;
		StartCoroutine (HealthDecay (_decayRate));
	}

	void RestoreHandler ()
	{
		player.speed = playerOriginalSpeed;
		StopAllCoroutines ();
	}

	// Use this for initialization
	void Start () {
		player = GetComponent<PlayerMovement> ();
		HazardBase.SendHazard += SendHazardHandler;
		HazardBase.RestoreFromHazard += RestoreHandler;
	}

}
