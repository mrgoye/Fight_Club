using UnityEngine;
using System.Collections;

public class CentainesScript : MonoBehaviour {

	public Sprite[] sprites;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(GlobalScript.bagDamage >= 100)
			GetComponent<SpriteRenderer>().sprite = sprites[0];
	    if(GlobalScript.bagDamage >= 200 )
			GetComponent<SpriteRenderer>().sprite = sprites[1];
		if(GlobalScript.bagDamage >= 300 )
			GetComponent<SpriteRenderer>().sprite = sprites[2];
		if(GlobalScript.bagDamage >= 400 )
			GetComponent<SpriteRenderer>().sprite = sprites[3];
		if (GlobalScript.bagDamage >= 500 )
			GetComponent<SpriteRenderer>().sprite = sprites[4];
		if(GlobalScript.bagDamage >= 600 )
			GetComponent<SpriteRenderer>().sprite = sprites[5];
		if(GlobalScript.bagDamage >= 700 )
			GetComponent<SpriteRenderer>().sprite = sprites[6];
		if(GlobalScript.bagDamage >= 800 )
			GetComponent<SpriteRenderer>().sprite = sprites[7];
		if(GlobalScript.bagDamage >= 900 )
			GetComponent<SpriteRenderer>().sprite = sprites[8];
	}
}
