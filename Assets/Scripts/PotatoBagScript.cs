﻿using UnityEngine;
using System.Collections;

public class PotatoBagScript : MonoBehaviour {

	public float force;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D obj){
		if (obj.gameObject.layer == 8) { 
			GetComponent<Animator> ().SetBool ("isPunched", true);
			this.transform.Translate (Vector2.up * force);
			this.transform.Translate(Vector2.right * force);
			GlobalScript.combo++;
			Debug.Log(GlobalScript.combo);
		}
	}

	void OnTriggerExit2D(Collider2D obj) {
		if(obj.gameObject.layer == 8)
			GetComponent<Animator>().SetBool("isPunched", false);
	}
}
