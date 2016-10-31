using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; 

public class loadMacy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame

		void OnTriggerEnter (Collider other) {
			UnityEngine.SceneManagement.SceneManager.LoadScene (4);

		}
	
	}
