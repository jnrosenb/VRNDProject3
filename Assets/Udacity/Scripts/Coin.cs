using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
	[Header("Particle System")]
	public ParticleSystem coinPoof;

	[Header("Audio")]
	public AudioSource aSource;

    public void OnCoinClicked() 
	{
		// Play sound
		aSource.Play ();
		
		// Instantiate the CoinPoof Prefab where this coin is located
		// Make sure the poof animates vertically
		coinPoof.transform.position = gameObject.transform.position;
		coinPoof.transform.rotation = Quaternion.Euler (270, 0, 0);
		coinPoof.Emit (100);
        
		// Destroy this coin. Check the Unity documentation on how to use Destroy
		GameObject.Destroy(gameObject);
    }

}
