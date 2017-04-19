using UnityEngine;
using System.Collections;

public class NemesisMovements : MonoBehaviour {

	public float speed;
	public float jumpForce;

	public float attackRate = 0.3f;
	private bool[] attack = new bool[2];
	private float[] attackTimer = new float[2];
	private int[] timesPressed = new int[2];

	private bool isLeft = false;

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
		anim.SetBool ("Attack_1", attack [0]);
		anim.SetBool ("Attack_2", attack [1]);


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
		} else if (Input.GetKeyDown (KeyCode.L)) {
			attack [0] = true;
			attackTimer [0] = 0;
			timesPressed [0]++;

		} else if (Input.GetKeyDown (KeyCode.M)) {
			attack [1] = true;
			attackTimer [1] = 0;
			timesPressed [1]++;
		}

		if (attack [0]) {
			attackTimer [0] += Time.deltaTime;
			
			if (attackTimer [0] > attackRate || timesPressed [0] >= 4) {
				attackTimer [0] = 0;
				attack [0] = false;
				timesPressed [0] = 0;
			}
		}

		if (attack [1]) {
			attackTimer [1] += Time.deltaTime;
			
			if (attackTimer [1] > attackRate || timesPressed [1] >= 4) {
				attackTimer [1] = 0;
				attack [1] = false;
				timesPressed [1] = 0;
			}
		}

		if (GlobalScript.isGrounded) {
			anim.SetBool ("Grounded", true);
			anim.SetBool ("Jump", false);
		} else {
			anim.SetBool ("Grounded", false);
			anim.SetBool ("Jump", true);
		}


	}
}
