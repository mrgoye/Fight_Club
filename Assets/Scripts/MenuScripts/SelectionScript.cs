using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SelectionScript : MonoBehaviour {
    public GameObject versusButton;
    public GameObject trainingButton;
	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    public void versusClic()
    {
        //SceneManager.LoadScene(3); load le mode versus
    }
    public void trainingClic()
    {
        SceneManager.LoadScene(4);//load entrainement
    }
    public void retourClick()
    {
        SceneManager.LoadScene(0);
    }
}
