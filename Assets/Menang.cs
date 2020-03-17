using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menang : MonoBehaviour {

	public GameObject Win;
	public GameObject test;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.transform.tag == "Player") {
			//print ("Ok");
			Win.SetActive(true);
			test.SetActive (false);
		}
	}
}
