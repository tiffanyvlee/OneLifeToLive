//using UnityEngine;
//using System.Collections;
//
//public class donutSpawnTrigger : MonoBehaviour {
//
//	public GameObject donut;
//
//	// Use this for initialization
//	void Start () {
//	
//	}
//	
//	// Update is called once per frame
//	void Update () {
//	}
//
//		void OnTriggerEnter() {
//		GameObject temp = Instantiate( donut, transform.position, transform.rotation ) as GameObject;
//		temp.GetComponent<Rigidbody> ().AddForce (Vector3.up * 100);
//			
//		}
//	
//	
//}


using UnityEngine;
using System.Collections;

public class donutSpawnTrigger : MonoBehaviour {

	public Transform donut;

	public int numToSpawn = 50;

	GameObject[] storedSpawns;

	// Use this for initialization
	void OnTriggerEnter () {
	
		storedSpawns = new GameObject[numToSpawn];
		for (int i = 0; i<storedSpawns.Length; i++) {

			//Vector3 cubePos = new Vector3(Random.Range(-1f, 1f). Random.Range(-1f, 1f). Random.Range(-1f, 1f) );
			//storedSpawns [i] = Instantiate (thingToSpawn, cubePos * 30, Quaternion.identity) as GameObject;
			storedSpawns [i] = Instantiate (donut, Random.insideUnitSphere, Quaternion.identity) as GameObject;
		}
	}

	// Update is called once per frame
	void Update () {

	}

//	void OnTriggerEnter() {
//		GameObject temp = Instantiate( donut, transform.position, transform.rotation ) as GameObject;
//		temp.GetComponent<Rigidbody> ().AddForce (Vector3.up * 10);
//	
//
//		
//	}
}


