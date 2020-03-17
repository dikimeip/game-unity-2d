using UnityEngine;
using System.Collections;

public class peluru : MonoBehaviour {
	public int Spead;
	public float lifetime;
	public float distance;
	public LayerMask whatis;
	public int demage = 10;

	public GameObject MyDestroy;

	karakter MyKarakter;

	void Start () {
		MyKarakter = GameObject.Find ("Pitung").GetComponent<karakter> ();
		Invoke ("DestroyKarakter", lifetime);
	}
	
	// Update is called once per frame
	void Update () {
		if (MyKarakter.pindah == 1) {
			transform.Translate (Vector2.right * Spead * Time.deltaTime);
		} else if (MyKarakter.pindah == -1) {
			transform.Translate (Vector2.right * -Spead * Time.deltaTime);
		}

	}

	void DestroyKarakter(){
		Instantiate (MyDestroy, transform.position, Quaternion.identity);
		Destroy (gameObject);
	}

	void OnTriggerEnter2D (Collider2D Info){
		if (Info.transform.tag == "Enemy") {
			Debug.Log (Info.name);
			musuh mus = Info.GetComponent<musuh>();
					if (mus != null) {
						mus.TakeDamage (demage);
					}
					Destroy (gameObject);

		} else if (Info.transform.tag == "Tembak") {
			Debug.Log ("OOt");
			Destroy (gameObject);
		}
		//Debug.Log (Info.name);
//		musuh mus = Info.GetComponent<musuh>();
//		if (mus != null) {
//			mus.TakeDamage (demage);
//		}
//		Destroy (gameObject);
	}
}
