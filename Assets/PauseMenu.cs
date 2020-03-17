using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {
	public GameObject pause;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.Escape)) {
			pause.SetActive (true);
		}
	}

	public void ResumeGame(){
		//pause.SetActive (false);
		Application.LoadLevel (1);
	}

	public void SaveScane(){
		PlayerPrefs.SetInt ("currentscenesave", Application.loadedLevel);
	}

	public void Back(){
		Application.LoadLevel (0);
	}
}
