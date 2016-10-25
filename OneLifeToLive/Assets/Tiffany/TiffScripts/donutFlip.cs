using UnityEngine;
using System.Collections;

public class donutFlip : MonoBehaviour {
	float rotationSpeed = -20;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		// if I hit a specific key, open the trap door
		if (Input.GetKey (KeyCode.C)) {
			//if (Input.GetKey("t"))
			//if the ti key is hit
			print("open trap door");
			//rotate z to -90 degrees
			transform.Rotate( Vector3.forward * rotationSpeed);
		}

	}
}
