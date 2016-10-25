using UnityEngine;
using System.Collections;

public class lightSwitch : MonoBehaviour {
	//highlight MonoBehaviour, Light, etc. + command + ' to open link to lists of possible attributes

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	//when something enters the Trigger attached to this gameObject
	void OnTriggerEnter() {
		//get the light attached to this game object
		//turn that light on
		GetComponent<Light> ().enabled = true;
		GetComponent<Light> ().color = new Color (100, 100, 0);
		//Color is three variables between 0 and 1 or Color.cyan;, Color.magenta;, etc. 
	}






}
