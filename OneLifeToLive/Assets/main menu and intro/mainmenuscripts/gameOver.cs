using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	public void LoadScene(string introduction) {
		UnityEngine.SceneManagement.SceneManager.LoadScene (6);

	}
}
