﻿using UnityEngine;
using System.Collections;
using UnityEngineIn; 

public class GravityOff : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame

		void OnTriggerEnter (Collider other){
			GetComponent<Rigidbody>().useGravity = false;
		}
}