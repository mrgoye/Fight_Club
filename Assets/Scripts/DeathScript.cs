using UnityEngine;
using System.Collections;

public class DeathScript : MonoBehaviour {

	private Vector3 initialPos;

	// Use this for initialization
	void Start () {
		this.initialPos = this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void  OnTriggerEnter2D ( Collider2D col  ){
		if (col.gameObject.layer == 10) {
			StartCoroutine (Dead ());
		}

	}

	IEnumerator Dead() {
		Debug.Log ("dead");
		GetComponent<Renderer>().enabled = false;
		yield return new WaitForSeconds(1);
		this.transform.position = initialPos;
		Debug.Log ("respawn");
		GetComponent<Renderer>().enabled = true;
	}

}
