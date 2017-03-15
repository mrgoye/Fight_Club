using UnityEngine;
using System.Collections;

public class GlobalScript : MonoBehaviour {

	public static bool isWalking = false;
	public static bool isPunching = false;
	public static bool hasPunched = false;
	public static bool hasPunchedBis = false;
	public static bool hasUppercut = false;
	public static bool hasKicked = true;
	public static bool isPunched = false;
	public static int combo = 0;
	public static float bagDamage = 0;
	public static bool isGrounded = true;
	public static bool comboFinished = false;

	private float timeLeft = 3;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log ("Time left : " + timeLeft);
		if(combo > 0)
			checkCombo ();
	}

	void checkCombo(){
		timeLeft -= Time.deltaTime;
		if(timeLeft < 0){
			combo = 0;
			timeLeft = 3;
		}
	}
}
