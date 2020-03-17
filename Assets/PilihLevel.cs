using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PilihLevel : MonoBehaviour {
	public GameObject Resm;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void HalamanAwal(){
		Application.LoadLevel (0);
	}

	public void PlayGame(){
		Application.LoadLevel (1);
	}

	public void Level2(){
		Application.LoadLevel (2);
	}

	public void Level3(){
		//Application.LoadLevel (3);
	}

	public void Level4(){
		Application.LoadLevel (4);
	}

	public void loadGame () {

		Application.LoadLevel (PlayerPrefs.GetInt ("currentscenesave"));
	}

	public void Save()
	{
		PlayerPrefs.SetInt ("currentscenesave", Application.loadedLevel);
	}

	public void AboutGame(){
		Application.LoadLevel (5);
	}

	public void SettingGame(){
		Application.LoadLevel (6);
	}

	public void ExitGame(){
		Application.Quit ();
	}

	public void ResumeGame(){
		Resm.SetActive (false);
		Time.timeScale = 1f;
	}

		
}
