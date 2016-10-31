using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]

public class audio : MonoBehaviour {



//
//	void Start() {
//		AudioSource audio = GetComponent<AudioSource>();
//		audio.Play ();
//
//	}


	bool AudioBegin = false; 

	void Awake()
	{
		if (!AudioBegin) {
			AudioSource audio = GetComponent<AudioSource>();
			audio.Play();
			DontDestroyOnLoad (gameObject);
			AudioBegin = true;
		} 
	}
	void Update () {
		if(Application.loadedLevelName == "mainMenu")
		{
			AudioSource audio = GetComponent<AudioSource>();
			audio.Stop();
			AudioBegin = false; 
		}
	}

}