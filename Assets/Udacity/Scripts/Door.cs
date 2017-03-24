using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
	
	[Header("Audio Source")]
	public AudioSource aSource;
	public AudioClip[] clips;

	[Header("Animator y referencias")]
	public Animator animator;
	public GameObject leftDoor;
	public GameObject rightDoor;
	 
	[HideInInspector]public bool locked;
	[HideInInspector]public bool opening;	

	private bool wideOpen;
	private float elapsedTime;
	private Quaternion originL; 
	private Quaternion goalL; 
	private Quaternion originR;
	private Quaternion goalR; 

	void Start()
	{
		opening = false;
		wideOpen = false;
		elapsedTime = 0;

		locked = true; 
		aSource.clip = clips [0]; 

		originL = leftDoor.transform.rotation;
		goalL = originL * Quaternion.Euler (0, 0, 90);
		originR = rightDoor.transform.rotation;
		goalR = originR * Quaternion.Euler (0, 0, -90);
	}

    void Update() 
	{
		if (opening && !wideOpen) 
		{
			elapsedTime += Time.deltaTime;

			leftDoor.transform.rotation  = Quaternion.Lerp (originL, goalL, elapsedTime);
			rightDoor.transform.rotation = Quaternion.Lerp (originR, goalR, elapsedTime);

			if (elapsedTime >= 1f)
				wideOpen = true;
		} 

    }

    public void OnDoorClicked() 
	{
		if (!locked) {
			aSource.Play ();
			opening = true;
			gameObject.layer = 2;
			//animator.SetBool ("open", true);
		} 
		else 
		{
			aSource.Play ();
		}
    }

    public void Unlock()
    {
		locked = false;
		aSource.clip = clips [1];
    }
}
