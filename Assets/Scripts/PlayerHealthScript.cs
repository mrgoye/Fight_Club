using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerHealthScript : MonoBehaviour {
    
    int currentHeath;
    public Slider healthSlider;
		
    void Start()
    {
        currentHeath = 100;
    }
	// Update is called once per frame
	void Update () {
	}
    public void takeDamage(int degats)
    {
        currentHeath -= degats;
        healthSlider.value = currentHeath;
    }
}
