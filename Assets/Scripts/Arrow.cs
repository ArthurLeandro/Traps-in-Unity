using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(AudioSource))]
public class Arrow : MonoBehaviour {
public AudioClip fireSound;
public AudioClip hitSound;
AudioSource arrowSound;
public float arrowVelocity;
public float arrowLife = 2.0f;
private float timer = 0;

	// Use this for initialization
	void Start () {
		arrowSound = gameObject.GetComponent<AudioSource>();
		arrowSound.clip = fireSound;
		arrowSound.Play();
		gameObject.GetComponent<Rigidbody>().velocity = transform.forward * arrowVelocity;
	}

	void OnCollisionEnter ()
	{
		arrowSound.clip = hitSound;
		arrowSound.Play();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (timer <= arrowLife) {
			timer += Time.deltaTime;
		} else {
			Destroy(gameObject);
		}
	}
}
