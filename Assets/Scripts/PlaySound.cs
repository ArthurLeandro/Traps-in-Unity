using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class PlaySound : MonoBehaviour {

public void PlaySoundEffect (AudioClip assetSound)
	{
	AudioSource assetSource = GetComponent<AudioSource>();
	assetSource.clip = assetSound;
	assetSource.Play();
	}

}
