using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllerRA : MonoBehaviour {

	private Vector3 cameraOffset;
	public GameObject player; // how to find the player programmatically?

	// Use this for initialization
	void Start () {
		cameraOffset = transform.position - player.transform.position;
	}

	// Update is called once per frame
	// not the best place for camera updates
	//	void Update () {
	//		Vector3 camera_pos = transform.position;
	//		transform.position = player.transform.position + cameraOffset;
	//	}

	void LateUpdate () {
		Vector3 camera_pos = transform.position;
		transform.position = player.transform.position + cameraOffset;
	}
}