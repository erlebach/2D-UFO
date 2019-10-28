using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_c : MonoBehaviour {

	public float speed = .3f;
	private Rigidbody2D rigid;

	// Use this for initialization
	void Start () {
		rigid = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		// Add a force to the player
		rigid.AddForce (new Vector2(10, 0));

	}
}
