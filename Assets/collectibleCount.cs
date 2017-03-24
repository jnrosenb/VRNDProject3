using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectibleCount : MonoBehaviour {

	private bool hasKey = false;
	private int numberOfCoins = 0;

	public void getKey()
	{
		hasKey = true;
	}

	public void pickCoin()
	{
		numberOfCoins++;
	}
}
