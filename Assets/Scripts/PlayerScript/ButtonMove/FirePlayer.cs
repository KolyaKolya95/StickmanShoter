using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePlayer : MonoBehaviour {

	public GameObject firePrefabs;
	Transform firePosition;

	// Use this for initialization
	void Start () {
		firePosition = transform.FindChild("FirePos");
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			Fire ();
		}
	}

	void Fire()
	{
		Instantiate (firePrefabs, firePosition.position, Quaternion.identity);
	}

	void OnCollisionEnter2D(Collision2D fire)
	{
		if (fire.gameObject.tag =="Fire") 
		{
			print ("OK");
		}
	}
}
