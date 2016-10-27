using UnityEngine;
using System.Collections;

public class DungeonCrawlerCamera : MonoBehaviour {
	public GameObject target;
	public float damping = 1;
	Vector3 offset;
	// Use this for initialization
	void Start () {
		offset = transform.position - target.transform.position;

	}

	// Update is called once per frame
	void LateUpdate () {
		Vector3 desiredPosition = target.transform.position + offset;
		Vector3 position = Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime * damping);
		transform.position = position;
		transform.position = desiredPosition;

		transform.LookAt (target.transform.position);
	}
}