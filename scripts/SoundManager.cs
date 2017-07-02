using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

	public AudioSource thisClip; 

	bool active = true;

	// Use this for initialization
	void Start () {
		
	}

	public void SetAudioOn() {
		thisClip.Play ();
		active = true;
	}

	public void SetAudioOff() {
		thisClip.Stop ();
		active = false;
	}

	public void Alternating() {
		if (active)
			SetAudioOff ();
		if (active == false)
			SetAudioOn ();
	}

	// Update is called once per frame
	void Update () {
		
	}
}
