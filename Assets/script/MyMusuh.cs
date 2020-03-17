using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMusuh : MonoBehaviour {
	karakter MyKarakter;
	// Use this for initialization
	void Start () {
		MyKarakter = GameObject.Find ("Pitung").GetComponent<karakter> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.transform.tag == "Player") {
			//print ("Ok");
			MyKarakter.nyawas--;
			MyKarakter.ulang = true;
		}
	}
}
