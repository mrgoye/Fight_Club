using UnityEngine;
using System.Collections;
using UnityEngine.UI;
//using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {
    public AudioClip sound;
    private AudioSource source;
    public AudioSource fondSonore;
    public Canvas quitMenu;
    public Button startText;
    public Button exitText;
    // Use this for initialization
    void Start () {
        quitMenu = quitMenu.GetComponent<Canvas>();
        startText = startText.GetComponent<Button>();
        exitText = exitText.GetComponent<Button>();
        quitMenu.enabled = false;
        source = GetComponent<AudioSource>();
    }
	public void ExitPress()
    {
        source.PlayOneShot(sound);
        quitMenu.enabled = true;
        startText.enabled = false;
        exitText.enabled = false;
    }

    public void NoPress()
    {
        source.PlayOneShot(sound);
        quitMenu.enabled = false;
        startText.enabled = true;
        exitText.enabled = true;
    }
    public void StartLevel()
    {
        DontDestroyOnLoad(GameObject.Find("FondSonore"));
        Application.LoadLevel(1);//load Mod_Selection
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
