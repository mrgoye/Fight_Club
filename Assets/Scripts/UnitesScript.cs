using UnityEngine;
using System.Collections;

public class UnitesScript : MonoBehaviour {

	public Sprite[] sprites;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(GlobalScript.bagDamage % 10 == 0)
			GetComponent<SpriteRenderer>().sprite = sprites[0];
		else if(GlobalScript.bagDamage % 10 == 1)
			GetComponent<SpriteRenderer>().sprite = sprites[1];
		else if(GlobalScript.bagDamage % 10 == 2)
			GetComponent<SpriteRenderer>().sprite = sprites[2];
		else if(GlobalScript.bagDamage % 10 == 3)
			GetComponent<SpriteRenderer>().sprite = sprites[3];
		else if(GlobalScript.bagDamage % 10 == 4)
			GetComponent<SpriteRenderer>().sprite = sprites[4];
		else if(GlobalScript.bagDamage % 10 == 5)
			GetComponent<SpriteRenderer>().sprite = sprites[5];
		else if(GlobalScript.bagDamage % 10 == 6)
			GetComponent<SpriteRenderer>().sprite = sprites[6];
		else if(GlobalScript.bagDamage % 10 == 7)
			GetComponent<SpriteRenderer>().sprite = sprites[7];
		else if(GlobalScript.bagDamage % 10 == 8)
			GetComponent<SpriteRenderer>().sprite = sprites[8];
		else if(GlobalScript.bagDamage % 10 == 9)
			GetComponent<SpriteRenderer>().sprite = sprites[9];
	}
}
