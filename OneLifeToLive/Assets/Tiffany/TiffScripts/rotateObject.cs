using UnityEngine;
using System.Collections;

public class rotateObject : MonoBehaviour {

	public float xSpeed = 0.5f;
	public float ySpeed = 0.5f;
	public float zSpeed = 0.5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.Rotate (
			xSpeed * Time.deltaTime,
			ySpeed * Time.deltaTime,
			zSpeed * Time.deltaTime);

	}
}
