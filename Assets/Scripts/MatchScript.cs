




using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MatchScript : MonoBehaviour {

    public float timer;
    public Text timerText;
	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        timer = checkTimer();
        timerText.text = timer.ToString();
	}
    float checkTimer()
    {
        timer -= Time.deltaTime;
        if (timer< 0)
        {
            return 0;
        }
        return timer;
    }
}
