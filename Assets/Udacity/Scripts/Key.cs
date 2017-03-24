using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{

	[Header("Door reference")]
	public Door door;

	[Header("Particle System")]
	public ParticleSystem keyPoof;

	[Header("Audio Source")]
	public AudioSource aSource;
	public AudioClip[] clips;

	private bool keyCollected;

	void Start()
	{
		aSource.clip = clips [1];
		aSource.spatialBlend = 1.0f;
		aSource.Play ();
	}

	void Update()
	{
		//Not required, but for fun why not try adding a Key Floating Animation here :)
	}

	public void OnKeyClicked() 
	{
		// Call the Unlock() method on the Door
		door.Unlock ();

		// Set the Key Collected Variable to true
		keyCollected = true;

		// Play sound
		aSource.Stop ();
		aSource.clip = clips [0];
		aSource.spatialBlend = 0.0f;
		aSource.Play ();

		// Instantiate the CoinPoof Prefab where this coin is located
		// Make sure the poof animates vertically
		keyPoof.transform.position = gameObject.transform.position;
		keyPoof.transform.rotation = Quaternion.Euler (270, 0, 0);
		keyPoof.Emit (100);

		// Destroy this coin. Check the Unity documentation on how to use Destroy
		GameObject.Destroy(gameObject);
	}
}
