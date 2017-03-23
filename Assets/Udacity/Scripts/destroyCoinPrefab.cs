using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyCoinPrefab : MonoBehaviour {


	public GameObject coin;

	public void Start()
	{
		transform.localScale = new Vector3(100, 100, 100);
	}
	
	// Update is called once per frame
	void Update () {

		if (coin == null)
			GameObject.Destroy (gameObject, 0.5f);
			
	}
}
