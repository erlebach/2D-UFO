using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Shredder_c : MonoBehaviour {
	public GameObject pebble;
	public float ypos;
	public float xmin, xmax;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		// make it rain
		// Create objects at random x locations
		//Instantate(pebble);
		createPebble();
	}

	void OnTriggerEnter2D(Collider2D other) {
		print ("Trigger");
		print (other.gameObject.tag);
		if (other.gameObject.tag == "Pebble") {
			Destroy (other.gameObject);
		}
	}

	public void createPebble() {
		// random x position
		Vector3 pos = new Vector3(Random.Range(xmin,xmax), ypos, 0f);
		GameObject peb = Instantiate (pebble, pos, Quaternion.identity);
	}
}
