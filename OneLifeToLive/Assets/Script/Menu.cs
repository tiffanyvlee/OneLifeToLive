﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
	public Canvas quitMenu;
	public Button startText;
	public Button exitText;

	// Use this for initialization
	void Start () {
		quitMenu = quitMenu.GetComponent<Canvas> (); 
		startText = startText.GetComponent<Button> (); 
		exitText = exitText.GetComponent<Button> (); 
		quitMenu.enabled = false; 

	}

	// Update is called once per frame
	void Update() {
	if(Input.GetKeyDown(KeyCode.Q)){
			ExitPress();
	}
	}
	public void ExitPress() {
		quitMenu.enabled = true; 
		startText.enabled = false; 
		exitText.enabled = false; 
		}
	public void NoPress() {
		quitMenu.enabled = false; 	
		startText.enabled = true; 
		exitText.enabled = true; 	
	}
	public void StartLevel(){
		SceneManager.LoadScene (1);
	}
	public void ExitGame() {
		Application.Quit ();
	}
	public void GoToInstagram(){
		Application.OpenURL ("https://www.instagram.com/the.kinardist");
	}
	public void GoToTwitter(){
		Application.OpenURL ("https://www.twitter.com/thekinardist");
	}
}
