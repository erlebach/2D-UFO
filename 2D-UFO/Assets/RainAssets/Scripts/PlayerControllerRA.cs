using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControllerRA : MonoBehaviour {
	private Rigidbody2D rb2d;
	private Vector2 force;
	public float speed;
	private int count;
	public Text countText, winText;
	public Button newLevelButton;
	private AudioClip crunch; // used to change what the audioSource plays
	public AudioSource audioSource;
	private AudioClip backgroundMusic;
	public AudioSource backgroundSource;
	public string levelName;

	// Use this for initialization
	void Start () {
		print ("gordon");
		rb2d = GetComponent<Rigidbody2D> ();
		count = 0;
		print ("gg");
		CountText ();
		winText.text = "";
		winText.enabled = false;
		newLevelButton.enabled = false;
		//Destroy (newLevelButton);
		print (newLevelButton);
		print ("G");

		crunch = audioSource.clip;
		audioSource.enabled = true;
		print ("mute: " + audioSource.mute);

		backgroundSource.Play ();
		print ("Level " + levelName);
		//print (rb2d);
	}

	void CountText () {
		countText.text = "Count: " + count.ToString ();
	}

	// Update is called once per frame
	void Update () {

	}

	void FixedUpdate () {
		float moveX = Input.GetAxis ("Horizontal");
		float moveY = Input.GetAxis ("Vertical");
		Vector2 movement = new Vector2 (moveX, moveY);
		rb2d.AddForce (movement * Time.deltaTime * speed);
	}

	void OnTriggerEnter2D (Collider2D collider) {
		GameObject obj = collider.gameObject;
		if (obj.name.StartsWith ("Pickup")) {
			// Alternative
			// if (obj.compareTag("Pickup")
			//Destroy (obj);
			obj.SetActive (false);
			//GetComponent<AudioSource> ().Play (); //crunch.Play ();
			//audioSource.volume = 3;
			print (crunch.samples);
			audioSource.enabled = true; // should not be required
			audioSource.PlayOneShot (crunch, 5f); //nosounds.Why?
			print ("crunch: " + crunch);
			count++;
			CountText ();

			// 9 is hardcoded. Bad idea. Why if I change number of PickUps?
			if (count == 9) {
				winText.enabled = true; // does not work
				winText.text = "All items have been collected!\nYou Win!";
				newLevelButton.enabled = false;
				Text text = newLevelButton.GetComponent<Text> ();
				text.text = "frances";
				// Invoke
				//Invoke ("CompletionLevel", 2.5f);
			}
		}
	}

	void CompletionLevel () {
		print ("change level to Completion");
		LevelManagerRA levelManager = FindObjectOfType<LevelManagerRA> ();
		levelManager.NextLevel ("Completion");
	}
}