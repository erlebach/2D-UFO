using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpTranslateRA : MonoBehaviour {

	// minimum and maximum velocity
	public float Vmin, Vmax;
	float vel; // private by default 
	Vector3 dir; // direction, unit vector
	Vector3 pos; // Pickup position
	float speed;
	PickupRotator rotator;

	void Awake () {
		if (Vmax < Vmin) {
			Debug.LogError ("Vmin must be less than Vmax");
			//Application.Quit ();
		}
		if (Vmax > 0) {
			rotator = GetComponent<PickupRotator> ();
			rotator.enabled = false;
		}
	}

	// Use this for initialization
	void Start () {
		// stop rotation
		// random speed between Vmin and Vmax
		speed = Random.Range (Vmin, Vmax);
		//speed = 2f;
		dir = Random.onUnitSphere;
		dir = Vector3.Normalize (transform.position);
		//print (dir);
		//print("speed= " + speed);

	}

	// Update is called once per frame
	void Update () {
		float distance = Time.deltaTime * speed * .5f;
		transform.position -= distance * dir;
		//print ("pos= " + transform.position); 
	}

	void OnTriggerEnter2D (Collider2D collider) {
		// reverse direction if trigger with wall
		dir = -dir;
	}
}