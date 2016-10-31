using UnityEngine;
using System.Collections;

public class resetbutton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.X)) {
			UnityEngine.SceneManagement.SceneManager.LoadScene (0);
		}
	
	}
}
