using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class karakter : MonoBehaviour {
	public int spead,kekuatanlompat;
	Rigidbody2D lompat;
	// Use this for initialization
	//balik badan
	public bool balik;
	public int pindah;

	//cek tanah
	public bool tanah;
	public LayerMask layartarget;
	public Transform deteksitanah;
	public float jangkauan;

	//animasi
	Animator anim;

	//arah
	public bool TombolKiri,TombolKanan;

	//koin
	Text MyNyawa,MyPoint;
	public int poins,nyawas;
	public GameObject GameOver;
	public GameObject Karakters;
	public GameObject Ecsape;

	//balik ke awal
	Vector2 mulai;
	public bool ulang;

	void Start () {
		Time.timeScale = 1f;
		lompat = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
		MyNyawa = GameObject.Find ("Nyawa").GetComponent<Text> ();
		MyPoint = GameObject.Find ("poin").GetComponent<Text> ();
		mulai = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		//Time.timeScale = 1f;
		if (ulang == true) {
			transform.position = mulai;
			ulang = false;
		}
		//poin
		if (nyawas <= 0) {
			GameOver.SetActive (true);
			Karakters.SetActive (false);
			nyawas = 0;
		}
		//tampilkan poin
		MyPoint.text = poins.ToString();
		MyNyawa.text = nyawas.ToString ();
		//cek tanah
		tanah = Physics2D.OverlapCircle (deteksitanah.position, jangkauan, layartarget);
		//animasi loncat
		if (tanah == true) {
			anim.SetBool ("lompat", false);
		} else {
			anim.SetBool ("lompat", true);
		}

		//arah
		if (Input.GetKey (KeyCode.D) || (TombolKanan == true) ) {
			anim.SetBool ("lari", true);
			transform.Translate (Vector2.right * -spead * Time.deltaTime);
			//balikbadan
			pindah = -1;
		} else if (Input.GetKey (KeyCode.A) || (TombolKiri == true)) {
			anim.SetBool ("lari", true);
			transform.Translate (Vector2.right * spead * Time.deltaTime);
			//balikbadan
			pindah = 1;
		} else {
			anim.SetBool ("lari", false);

			if (tanah == true && (Input.GetKey (KeyCode.Z))) {
				lompat.AddForce (new Vector2 (0, kekuatanlompat));
			}

			if (pindah > 0 && !balik) {
				balikbadan ();
			} else if (pindah < 0 && balik) {
				balikbadan ();
			}
		}


		if (Input.GetKey(KeyCode.Escape)) {
			Ecsape.SetActive (true);
			Time.timeScale = 0f;
		}
	}



	//cek posisi balikbadan
	void balikbadan(){
		balik = !balik;
		Vector3 karakter = transform.localScale;
		karakter.x *= -1;
		transform.localScale = karakter;
	}

	public void TekanKiri(){
		TombolKiri = true;
	}

	public void LepasKiri(){
		TombolKiri = false;
	}

	public void TekanKanan(){
		TombolKanan = true;
	}

	public void LepasKanan(){
		TombolKanan = false;
	}

	public void loncat(){
		if (tanah == true) {
			lompat.AddForce (new Vector2 (0, kekuatanlompat));
		}
	}

}
