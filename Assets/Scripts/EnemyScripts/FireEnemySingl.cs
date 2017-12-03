using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireEnemySingl : MonoBehaviour {
	
	public GameObject firePrefabs;
	Transform firePosition;

	private float timeInSecondsP;
	private int secondsP;
	private float speed;

    public AudioClip sound;

    private AudioSource source { get { return GetComponent<AudioSource>(); } }

    // Use this for initialization
    void Start () {
		firePosition = transform.Find("FirePosEnemi");
        gameObject.AddComponent<AudioSource>();
        source.clip = sound;
        source.playOnAwake = false;
    }

	// Update is called once per frame
	void Update ()
	{
		timeInSecondsP += Time.deltaTime;

		secondsP = (int)(timeInSecondsP % 60);

		print (secondsP);

		if (secondsP == 2) 
		{
			Fire ();
			timeInSecondsP = 0;
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
