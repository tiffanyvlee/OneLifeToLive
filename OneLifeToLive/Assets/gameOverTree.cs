using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class gameOverTree : MonoBehaviour {

	void OnTriggerEnter (Collider other) {
		UnityEngine.SceneManagement.SceneManager.LoadScene (6);

	}
}
