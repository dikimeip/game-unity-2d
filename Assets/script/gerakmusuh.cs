using UnityEngine;
using System.Collections;

public class gerakmusuh : MonoBehaviour {
	public int spead;

	karakter MyKarakter;
	// Use this for initialization
	void Start () {
		MyKarakter = GameObject.Find ("Pitung").GetComponent<karakter> ();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector2.left * spead * Time.deltaTime);
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.transform.tag == "Player") {
			//print ("Ok");
			MyKarakter.nyawas--;
			MyKarakter.ulang = true;
		}
	}
}
