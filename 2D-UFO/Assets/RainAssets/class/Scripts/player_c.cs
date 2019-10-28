using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player_c : MonoBehaviour {
	private float x; // horizontal value,  x_pos, x_position, Xp
	private float y;
	Rigidbody2D rb;// private
	public float speed;
	private int count; // number of pickups collected
	public int nbPickups; 
	public Text countText;
	public Text winText;
	public AudioSource backgroundMusic;
	public AudioSource boneCrunch;
	public GameObject asteroid;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		count = 0;
		countText.text = "Counter: 0";
		winText.text = "";

	// Create new objects
//		for (int i=0; i < 5; i++){
//			GameObject aster = Instantiate (asteroid);
//			Vector3 pos = asteroid.transform.position + new Vector3 (.2f, 0f, 0f);
//			aster.transform.position = pos;
//		}
	}

	void Update() {
		//print ("Update");
		if (count >= nbPickups) {
			speed = 0f;
			winText.text = "You won the game!";
			rb.velocity = Vector3.Lerp (rb.velocity, Vector3.zero, Time.deltaTime);//Time.deltaTime);
		}
	}

	// FixedUpdate is called once per frame used for physics
	void FixedUpdate () {
		//print ("fixedUpdate");
		x = Input.GetAxis ("Horizontal");
		y = Input.GetAxis ("Vertical");
		rb.AddForce (new Vector2 (x * speed, y * speed));
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.CompareTag("PickUp")) {
			other.gameObject.SetActive (false);
			count = count + 1;
			countText.text = "Counter: " + count;
			boneCrunch.Play ();
		}
	}
}
