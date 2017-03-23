using UnityEngine;
using System.Collections;

public class PotatoBagScript : MonoBehaviour {

    //PlayerHealthScript phs;
	public float force;

	// Use this for initialization
	void Start () {
        //phs = gameObject.GetComponentInChildren<PlayerHealthScript>() ;
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D obj){
		if (obj.gameObject.layer == 8) { 
			GetComponent<Animator> ().SetBool ("isPunched", true);

			/*if(GlobalScript.comboFinished){
				GetComponent<Rigidbody2D>().AddForce (Vector2.up * force);
				GetComponent<Rigidbody2D>().AddForce (Vector2.right * force);
			}

			if(GlobalScript.hasUppercut) {
				GetComponent<Rigidbody2D>().AddForce (Vector2.up * force);
			}*/

			if(GlobalScript.hasPunched)
				GlobalScript.bagDamage += 3;
			if(GlobalScript.hasPunchedBis)
				GlobalScript.bagDamage += 4;
			if(GlobalScript.hasKicked)
				GlobalScript.bagDamage += 6;
			if(GlobalScript.hasUppercut)
				GlobalScript.bagDamage += 10;
			//GlobalScript.combo++;
			force += GlobalScript.bagDamage;
			Debug.Log("Dammage : " + GlobalScript.bagDamage + "%");
		}
        if (obj.gameObject.layer == 8)
        {
            //phs.takeDamage(10);
            GetComponent<Animator>().SetBool("isPunched", true);
			//GetComponent<Rigidbody2D>().AddForce (Vector2.up * force);
			//GetComponent<Rigidbody2D>().AddForce (Vector2.right * force);
            GlobalScript.combo++;
            Debug.Log(GlobalScript.combo);
        }
	}

	void OnTriggerExit2D(Collider2D obj) {
		if(obj.gameObject.layer == 8)
			GetComponent<Animator>().SetBool("isPunched", false);
	}
}
