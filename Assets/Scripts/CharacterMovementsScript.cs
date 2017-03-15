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

		if (Input.GetKeyDown (KeyCode.Space) && GlobalScript.isGrounded) {
			GetComponent<Rigidbody2D> ().AddForce (Vector2.up * jumpForce);
		}

		if (Input.GetKey (KeyCode.D)) {
			GlobalScript.isWalking = true;
			GetComponent<Animator> ().SetBool ("isWalking", true);
			this.transform.Translate (Vector2.right * speed);
			if (this.isLeft) {
				this.transform.Rotate (0, 180, 0);
				this.isLeft = false;
			}
		} else if (Input.GetKey (KeyCode.Q)) {
			GlobalScript.isWalking = true;
			GetComponent<Animator> ().SetBool ("isWalking", true);
			this.transform.Translate (Vector2.right * speed);
			if (!this.isLeft) {
				this.transform.Rotate (0, 180, 0);
				this.isLeft = true;
			}
		} else if (Input.GetKeyDown (KeyCode.M) && !Input.GetKey (KeyCode.Z)) {
			GlobalScript.combo++;
			//Debug.Log(GlobalScript.combo);
			GlobalScript.isPunching = true;
			GlobalScript.isWalking = false;

			if (GlobalScript.combo % 2 == 1 && GlobalScript.hasKicked) {
				//Debug.Log ("1st punch");
				GlobalScript.comboFinished = false;
				GlobalScript.hasPunched = true;
				GlobalScript.hasPunchedBis = false;
				GlobalScript.hasKicked = false;
				GetComponent<Animator> ().SetBool ("isPunching", true);
				GetComponent<Animator> ().SetBool ("isPunchingBis", false);
				GetComponent<Animator> ().SetBool ("isKicking", false);
				GetComponent<Animator> ().SetBool ("isUppercut", false);
			}
			if (GlobalScript.combo % 2 == 0 && GlobalScript.hasPunched) {
				//Debug.Log ("2nd punch");
				GlobalScript.hasPunched = false;
				GlobalScript.hasPunchedBis = true;
				GlobalScript.hasKicked = false;
				GetComponent<Animator> ().SetBool ("isPunching", false);
				GetComponent<Animator> ().SetBool ("isPunchingBis", true);
				GetComponent<Animator> ().SetBool ("isKicking", false);
				GetComponent<Animator> ().SetBool ("isUppercut", false);
			}
			if (GlobalScript.combo % 2 == 1 && GlobalScript.hasPunchedBis) {
				//Debug.Log ("kick");
				GlobalScript.hasPunched = false;
				GlobalScript.hasPunchedBis = false;
				GlobalScript.hasKicked = true;
				GetComponent<Animator> ().SetBool ("isPunching", false);
				GetComponent<Animator> ().SetBool ("isPunchingBis", false);
				GetComponent<Animator> ().SetBool ("isKicking", true);
				GetComponent<Animator> ().SetBool ("isUppercut", false);
				GlobalScript.comboFinished = true;
			}
		} else if (Input.GetKey (KeyCode.M) && Input.GetKey (KeyCode.Z)) {
			GlobalScript.isPunching = true;
			GlobalScript.isWalking = false;
			GlobalScript.hasUppercut = true;
			GetComponent<Animator> ().SetBool ("isUppercut", true);
		}
		if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Battler_Kicking")) {
			GetComponent<Animator>().SetBool("isKicking", false);
		}
		if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Battler_Uppercut")) {
			GetComponent<Animator>().SetBool("isUppercut", false);
			GlobalScript.hasUppercut = false;
		}

		//if(!Input.anyKey) {
		   	//GetComponent<Animator>().SetBool("isPunching", false);
		   	//GetComponent<Animator>().SetBool("isPunchingBis", false);
		   //	GetComponent<Animator>().SetBool("isKicking", false);
			//GetComponent<Animator>().SetBool("isWalking", false);
		//}
	}
}
