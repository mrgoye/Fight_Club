using UnityEngine;
using System.Collections;

public class GlobalScript : MonoBehaviour {

	public static bool isWalking = false;
	public static bool isPunching = false;
	public static bool isPunched = false;
	public static int combo = 0;
	public static bool isGrounded = true;

	private float timeLeft = 3;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//checkCombo ();
	}

	void checkCombo(){
		timeLeft -= Time.deltaTime;
		if(timeLeft < 0){
			combo = 0;
		}
	}
}
