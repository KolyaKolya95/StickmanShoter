using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

	public float speedY;
	public GameObject gameOverPanel;

	public bool life = true;

	//bool facingUp, facingDown;

	Rigidbody2D rb;
	float speed;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		//facingUp = true;
	}
	
	// Update is called once per frame
	void Update () {
		Move (speed);

		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			speed = speedY;
		} 

		if (Input.GetKeyUp (KeyCode.UpArrow)) {
			speed = 0;
		} 

		if (Input.GetKeyDown (KeyCode.DownArrow)) 
		{
			speed = -speedY;
		}

		if (Input.GetKeyUp (KeyCode.DownArrow)) 
		{
			speed = 0;
		}
	}
		
//	void Flip()
//	{
//		if (speed > 0 && !facingUp || speed < 0 && facingUp)
//		{
//			facingUp = !facingDown;
//		}
//	}

//	void OnCollisionEnter2D(Collision2D other)
//	{
//		if (other.gameObject.tag == "GROUND") 
//		{
//			speed = 0;
//		}
//	}

	void OnCollisionEnter2D(Collision2D fire)
	{
		if (fire.gameObject.CompareTag("GameOver")) 
		{
			gameOverPanel.SetActive (true);
		}
	}

	public void DonwWalkUp()
	{
		Move (speed);
		speed = speedY;
	}

	public void UpWalkUp()
	{
		Move (speed);
		speed = 0;
	}

	public void DownWalkDown()
	{
		Move (speed);
		speed = -speedY;
	}

	public void UpWalkDown()
	{
		Move (speed);
		speed = 0;
	}

	void Move(float playerSpeed)
	{

		rb.velocity = new Vector3(rb.velocity.x, speed, 0);
	}
}
