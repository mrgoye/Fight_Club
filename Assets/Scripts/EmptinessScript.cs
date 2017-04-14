using UnityEngine;
using System.Collections;

public class EmptinessScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void  OnTriggerEnter2D ( Collider2D col  ){
		var explosion = this.transform.GetChild (0);
		explosion.transform.position = col.transform.position;
		explosion.GetComponent<Animator> ().SetBool ("hasFallen", true);
	}

	void OnTriggerExit2D( Collider2D col) {
		var explosion = this.transform.GetChild (0);
		explosion.GetComponent<Animator> ().SetBool ("hasFallen", false);
	}
}
