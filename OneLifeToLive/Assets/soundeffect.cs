using UnityEngine;
using System.Collections;

public class soundeffect : MonoBehaviour {
    public AudioSource jump;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<AudioSource>();
            jump.Play();
        }
	}
}
