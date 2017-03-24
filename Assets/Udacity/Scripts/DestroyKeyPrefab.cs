using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyKeyPrefab : MonoBehaviour {

	public GameObject key;

	public void Start()
	{
		//transform.localScale = new Vector3(100, 100, 100);
	}

	// Update is called once per frame
	void Update () {

		if (key == null)
			GameObject.Destroy (gameObject, 0.5f);

	}
}