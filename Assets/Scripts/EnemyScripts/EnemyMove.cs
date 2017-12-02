using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

	private GameObject findPoint;
	private	Rigidbody2D rb;

	private float timeInSecondsP;
	private float speedY = 5;
	private int secondsP;
	private float speed;

	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () 
	{

		timeInSecondsP += Time.deltaTime;

		secondsP = (int)(timeInSecondsP % 60);

		//print (secondsP);

		Move (speed);

		if (secondsP == 1) {
			speed = speedY;
		} else if (secondsP >= 4) 
		{
			speed = -speedY;
			//timeInSecondsP = 0;
		}
		if (secondsP == 7) 
		{
			timeInSecondsP = 0;
		}
	}

	void Move(float playerSpeed)
	{
		rb.velocity = new Vector3(rb.velocity.x, speed, 0);
	}
}
