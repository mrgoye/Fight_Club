using UnityEngine;
using System.Collections;

public class NemesisMovements : MonoBehaviour {

	public float speed;
	public float jumpForce;
	public float attackRate = 0.1f;


	private int indexAttack = 1;
	private bool isLeft = false;
	private float attackTimer = 0;

	private Animator anim;


	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		CheckMovements ();
	}

	void CheckMovements(){
		GlobalScript.isWalking = false;
		anim.SetBool ("Walk", false);

		if (Input.GetKey (KeyCode.D)) {
			GlobalScript.isWalking = true;
			anim.SetBool ("Walk", true);
			this.transform.Translate (Vector2.right * speed);
			GlobalScript.characterIsLeft = false;
			if (this.isLeft) {
				this.transform.Rotate (0, 180, 0);
				this.isLeft = false;
			}
		} else if (Input.GetKey (KeyCode.Q)) {
			GlobalScript.isWalking = true;
			anim.SetBool ("Walk", true);
			this.transform.Translate (Vector2.right * speed);
			GlobalScript.characterIsLeft = true;
			if (!this.isLeft) {
				this.transform.Rotate (0, 180, 0);
				this.isLeft = true;
			}
		} else if (Input.GetKeyDown (KeyCode.Space) && GlobalScript.isGrounded) {
			GetComponent<Rigidbody2D> ().AddForce (Vector2.up * jumpForce);
		} else if (Input.GetKeyDown (KeyCode.M)) {
			if(indexAttack > 1)
				anim.ResetTrigger("Attack_" + (indexAttack - 1));
			else if (indexAttack == 1 )
				anim.ResetTrigger("Attack_3");

			anim.SetTrigger("Attack_" + indexAttack);

			if (indexAttack >= 3) 
				indexAttack = 1;
			else
				indexAttack++;
		}

		if (indexAttack > 1)
			attackTimer += Time.deltaTime;
		else 
			attackTimer = 0;

		if (attackTimer > attackRate) {
			indexAttack = 1;
		}

		Debug.Log(indexAttack + " et " + attackTimer);

		if (GlobalScript.isGrounded) {
			anim.SetBool ("Grounded", true);
			anim.SetBool ("Jump", false);
		} else {
			anim.SetBool ("Grounded", false);
			anim.SetBool ("Jump", true);
		}


	}
}
