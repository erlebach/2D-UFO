using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupRotatorRA : MonoBehaviour {
	public float speed;

	// Update is called once per frame
	void Update () {
		float angle = speed * Time.deltaTime;
		transform.Rotate (new Vector3 (0, 0, angle));
		//transform.rotation = transform.rotation + new Vector3 (0f, 0f, angle);

	}
}