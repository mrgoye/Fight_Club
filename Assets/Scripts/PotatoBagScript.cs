using UnityEngine;
using System.Collections;

public class PotatoBagScript : MonoBehaviour {

	public float force;
	public AudioClip bam;
	public AudioClip hit;
	public AudioSource audioSource;
	private float initialForce;

	// Use this for initialization
	void Start () {
		initialForce = force;
	}
	
	// Update is called once per frame
	void Update () {
		if (this.transform.position.y > 9.5)
			GetComponent<Animator>().SetBool("isRotating", true);
		else
			GetComponent<Animator>().SetBool("isRotating", false);
	}

	void OnTriggerEnter2D(Collider2D obj){
		if (obj.gameObject.layer == 8) { 
			GetComponent<Animator> ().SetBool ("isPunched", true);
			if(GlobalScript.hasPunched || GlobalScript.hasPunchedBis || GlobalScript.hasKicked)
				audioSource.PlayOneShot(bam);


			if(GlobalScript.comboFinished){
				GetComponent<Rigidbody2D>().AddForce (Vector2.up * force);
				if(!GlobalScript.characterIsLeft)
					GetComponent<Rigidbody2D>().AddForce (Vector2.right * force);
				else
					GetComponent<Rigidbody2D>().AddForce (Vector2.left * force);
			}

			if(GlobalScript.hasUppercut) {
				audioSource.PlayOneShot(hit);
				GetComponent<Rigidbody2D>().AddForce (Vector2.up * force);
			}

			if(GlobalScript.hasPunched)
				GlobalScript.bagDamage += 3;
			if(GlobalScript.hasPunchedBis)
				GlobalScript.bagDamage += 4;
			if(GlobalScript.hasKicked)
				GlobalScript.bagDamage += 6;
			if(GlobalScript.hasUppercut)
				GlobalScript.bagDamage += 10;
			//GlobalScript.combo++;
			force += GlobalScript.bagDamage;
			Debug.Log("Dammage : " + GlobalScript.bagDamage + "%");
		}

		if (obj.gameObject.layer == 10) {
			GlobalScript.bagDamage = 0;
			force = initialForce;
			GetComponent<Rigidbody2D>().velocity = Vector3.zero;
		}
	}

	void OnTriggerExit2D(Collider2D obj) {
		if(obj.gameObject.layer == 8)
			GetComponent<Animator>().SetBool("isPunched", false);
	}
}
