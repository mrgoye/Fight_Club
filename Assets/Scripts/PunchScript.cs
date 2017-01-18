using UnityEngine;
using System.Collections;

public class PunchScript : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Punch ();
	}

	void Punch() {
		GetComponent<BoxCollider2D> ().offset = new Vector2(0, 0);
		if (GlobalScript.isPunching) {
			GetComponent<BoxCollider2D> ().offset = new Vector2(0.8f ,0.05f);
		}
	}
}
