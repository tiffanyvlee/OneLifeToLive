using UnityEngine;
using System.Collections;

public class soundeffect : MonoBehaviour {
    public AudioSource Jump;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
			AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
        }
	}
}
