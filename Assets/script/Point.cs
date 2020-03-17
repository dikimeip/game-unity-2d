using UnityEngine;
using System.Collections;

public class Point : MonoBehaviour {

	//public GameObject Suara;
	public AudioSource ButtonPoin;
	karakter kompkarakter;

	// Use this for initialization
	void Start () {
		kompkarakter = GameObject.Find ("Pitung").GetComponent<karakter> ();
		//ButtonPoin.mute;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.transform.tag == "Player") {
			kompkarakter.poins += 10;
			//Suara.SetActive (true);
	
			ButtonPoin.PlayOneShot(ButtonPoin.clip);
			Destroy (gameObject);
		}
	}
}
