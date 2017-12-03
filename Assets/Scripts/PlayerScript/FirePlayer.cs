using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePlayer : MonoBehaviour {

	public GameObject firePrefabs;
    Animator anim;
    Transform firePosition;

    public AudioClip sound;

    private AudioSource source { get { return GetComponent<AudioSource>(); } }

    // Use this for initialization
    void Start () {
       // anim.SetInteger("State", 0);
        //anim = GetComponent<Animator>();
		firePosition = transform.Find("FirePos");
        gameObject.AddComponent<AudioSource>();
        source.clip = sound;
        source.playOnAwake = false;
    }
	
	// Update is called once per frame
	void Update ()
	{
       // anim.SetInteger("State", 0);

		if (Input.GetKeyDown (KeyCode.Space)) 
		{
          //  anim.SetInteger("State", 2);
            Fire ();
		}
	}

	public void Fire()
	{
        source.PlayOneShot(sound);
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
