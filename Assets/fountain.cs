using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fountain : MonoBehaviour {

	[Header("Audio Source")]
	public AudioSource audioSource;

	// Use this for initialization
	void Start () {
		audioSource.playOnAwake = true;
		audioSource.spatialBlend = 1f;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
