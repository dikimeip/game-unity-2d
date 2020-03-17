using UnityEngine;
using System.Collections;

public class tembak : MonoBehaviour {
	public GameObject MyGame;
	public Transform layer;
	public bool Tembakk;

	private float TimeBtwShow;
	public float Starttime;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (TimeBtwShow <= 0) {
			if (Input.GetKey (KeyCode.C) || (Tembakk == true) ) {
				Instantiate (MyGame, layer.position, transform.rotation);
				TimeBtwShow = Starttime;
			}
		} else {
			TimeBtwShow -= Time.deltaTime;
		}



	}

    public void TemabkOn(){
		Tembakk = true;
	}

	public void TembakOf(){
		Tembakk = false;
	}
}
