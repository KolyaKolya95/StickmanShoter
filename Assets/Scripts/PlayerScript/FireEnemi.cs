using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireEnemi : MonoBehaviour {

	public GameObject firePrefabs;
    public AudioClip sound;

    private AudioSource source { get { return GetComponent<AudioSource>(); } }
    Transform firePosition;

    // Use this for initialization
    void Start ()
    {
		firePosition = transform.Find("FirePosEnemi");

        gameObject.AddComponent<AudioSource>();
        source.clip = sound;
        source.playOnAwake = false;
    }

	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Space)) 
		{
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
