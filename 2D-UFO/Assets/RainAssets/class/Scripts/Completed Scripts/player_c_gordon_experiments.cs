using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player_c_gordon_experiments : MonoBehaviour {
	private float x; // horizontal value,  x_pos, x_position, Xp
	private float y;
	Rigidbody2D rb;// private
	public float speed;
	private int count; // number of pickups collected
	public int nbPickups; 
	public Text counterText;
	public Text winText;
	public PhysicsMaterial2D mat2D;
	public AudioSource music;
	public AudioSource fx;  // special effects music
	private AudioClip music_clip;
	private AudioClip fx_clip;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		count = 0;
		counterText.text = "Count: " + count;
		winText.text = "";
		music.playOnAwake = true;
		fx.Pause ();
	}

	void Update() {
		if (count >= nbPickups) {
			print ("Game over, all objects collected");
			winText.text = "You Win!!!";
			speed = 0f;
			//rb.velocity = Vector3.zero;
			//mat2D.friction = 4f;
			//mat2D.bounciness = .2f;
			// Interpolate between 1st and 2nd argument. Third argument in [0,1]
			//  0 means 1st arg, 1 means 2nd arg, .3 means 1/3 from 1st arg to 2nd arg
			rb.velocity = Vector3.Lerp (rb.velocity, Vector3.zero, Time.deltaTime);//Time.deltaTime);
			print (rb.velocity);
		}
	}

	// FixedUpdate is called once per frame used for physics
	void FixedUpdate () {
		x = Input.GetAxis ("Horizontal");
		y = Input.GetAxis ("Vertical");
		//print ("update:" + x + "     " + y);
		rb.AddForce (new Vector2 (x * speed, y * speed));
	}

	void OnTriggerEnter2D(Collider2D other) {
		//print("enter OnTrigger");
		// check to see what the player hit

		if (other.CompareTag("PickUp")) {
			//print("hit pickup");
			other.gameObject.SetActive (false);
			count = count + 1;
			counterText.text = "Count: " + count;
			fx.Play ();
		}
	}
}
