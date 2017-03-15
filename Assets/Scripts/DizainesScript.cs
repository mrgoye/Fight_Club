using UnityEngine;
using System.Collections;

public class DizainesScript : MonoBehaviour {

	public Sprite[] sprites;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(GlobalScript.bagDamage % 100 < 10)
			GetComponent<SpriteRenderer>().sprite = sprites[0];
		if(GlobalScript.bagDamage % 100 >= 10)
			GetComponent<SpriteRenderer>().sprite = sprites[1];
	    if(GlobalScript.bagDamage % 100 >= 20 )
			GetComponent<SpriteRenderer>().sprite = sprites[2];
		if(GlobalScript.bagDamage % 100 >= 30 )
			GetComponent<SpriteRenderer>().sprite = sprites[3];
		if(GlobalScript.bagDamage % 100 >= 40 )
			GetComponent<SpriteRenderer>().sprite = sprites[4];
		if (GlobalScript.bagDamage % 100 >= 50 )
			GetComponent<SpriteRenderer>().sprite = sprites[5];
		if(GlobalScript.bagDamage % 100 >= 60 )
			GetComponent<SpriteRenderer>().sprite = sprites[6];
		if(GlobalScript.bagDamage % 100 >= 70 )
			GetComponent<SpriteRenderer>().sprite = sprites[7];
		if(GlobalScript.bagDamage % 100 >= 80 )
			GetComponent<SpriteRenderer>().sprite = sprites[8];
		if(GlobalScript.bagDamage % 100 >= 90 )
			GetComponent<SpriteRenderer>().sprite = sprites[9];
	}
}
