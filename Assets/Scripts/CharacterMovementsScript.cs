using UnityEngine;
using System.Collections;

public class CharacterMovementsScript : MonoBehaviour {

	public float speed;
	public float jumpForce;
	private bool isLeft = false;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		Walk ();
	}

	void Walk(){
		GlobalScript.isWalking = false;
		GlobalScript.isPunching = false;
		GetComponent<Animator> ().SetBool ("isWalking", false);
		GetComponent<Animator> ().SetBool ("isPunching", false);
		GetComponent<Animator> ().SetBool ("isPunchingBis", false);

		if (GlobalScript.isGrounded) {
			GetComponent<Animator> ().SetBool ("isGrounded", true);
			GetComponent<Animator> ().SetBool ("isJumping", false);
		} else {
			GetComponent<Animator>().SetBool ("isGrounded", false);
			GetComponent<Animator> ().SetBool ("isJumping", true);
		}


		if(Input.GetKey(KeyCode.D)){
			GlobalScript.isWalking = true;
			GetComponent<Animator> ().SetBool ("isWalking", true);
			this.transform.Translate (Vector2.right * speed);
			if(this.isLeft){
				this.transform.Rotate(0, 180, 0);
				this.isLeft = false;
			}
		}

		if (Input.GetKey (KeyCode.Q)) {
			GlobalScript.isWalking = true;
			GetComponent<Animator> ().SetBool ("isWalking", true);
			this.transform.Translate (Vector2.right * speed);
			if(!this.isLeft){
				this.transform.Rotate (0, 180, 0);
				this.isLeft = true;
			}
		}

		if (Input.GetKeyDown (KeyCode.Space) && GlobalScript.isGrounded) {
			GetComponent<Rigidbody2D> ().AddForce (Vector2.up * jumpForce);
		}

		if (Input.GetKeyDown (KeyCode.M)) {
			GlobalScript.isPunching = true;
			if(GlobalScript.combo%2 == 0){
				GetComponent<Animator>().SetBool("isPunching", true);
				GetComponent<Animator>().SetBool("isPunchingBis", false);
			}
			if (GlobalScript.combo%2 == 1) {
				GetComponent<Animator>().SetBool("isPunching", false);
				GetComponent<Animator>().SetBool("isPunchingBis", true);
			}
		}
	}
}
