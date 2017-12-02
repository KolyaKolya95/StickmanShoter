using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Experimental.UIElements;

public class BulateStr : MonoBehaviour {

	public GameObject GameOverPanel;

	public Vector2 speed;

	Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		GameOverPanel.SetActive (false);
		rb = GetComponent<Rigidbody2D> ();
		rb.velocity = speed;
		
	}
	
	// Update is called once per frame
	void Update () {
		rb.velocity = speed;
	}

	void OnCollisionEnter2D(Collision2D fire)
	{
		if (fire.gameObject.CompareTag("Player")) 
		{
			GameOverPanel.SetActive (true);
		}
	}
}
