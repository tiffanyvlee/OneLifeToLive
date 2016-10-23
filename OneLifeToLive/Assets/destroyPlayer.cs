using UnityEngine;
using System.Collections;

public class destroyPlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	void OnTriggerEnter(Collider other) {
		Destroy(other.gameObject);
	}
}
