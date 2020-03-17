using UnityEngine;
using System.Collections;

public class musuh : MonoBehaviour {
	public int healt = 100;
	public GameObject deadefect;

	karakter MyKarakter;
	// Use this for initialization

	public void TakeDamage(int demage){
		healt -= demage;
		if (healt <= 0) {
			Die ();
		}
	}

	void Die(){
		Instantiate (deadefect, transform.position, Quaternion.identity);
		Destroy (gameObject);
	}

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
