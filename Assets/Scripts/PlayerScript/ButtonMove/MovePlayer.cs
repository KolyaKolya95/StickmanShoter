using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour {

	public float speed = 20f;
	private Rigidbody2D rb;


	void Start () {
		rb = GetComponent <Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		float movexY = Input.GetAxis ("Vertical");
		rb.MovePosition (rb.position + Vector2.up * movexY * Time.deltaTime);
	}
}
