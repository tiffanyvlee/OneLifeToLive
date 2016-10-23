using UnityEngine;
using System.Collections;

public class spawn : MonoBehaviour {


	public GameObject hambuger;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.D)) {
			GameObject temp = Instantiate (hambuger, transform.position, transform.rotation) as GameObject;
			temp.GetComponent<Rigidbody> ().AddForce (Vector3.left * 5);
		}
	}
}
