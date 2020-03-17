using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mute : MonoBehaviour {

	bool muted;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (muted) {
			AudioListener.volume = 0;

		} else if (!muted) {

			AudioListener.volume = 1;
		}
	}

	public void Mute()
	{
		muted = !muted;

	}
}
