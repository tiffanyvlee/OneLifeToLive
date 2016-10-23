using UnityEngine;
using System.Collections;

public class ParticleTrigger : MonoBehaviour {
	//highlight MonoBehaviour, Light, etc. + command + ' to open link to lists of possible attributes

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other) {
		GetComponentInChildren<ParticleSystem>().Play();
	}





}
