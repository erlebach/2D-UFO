using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager_cc : MonoBehaviour {

	public float gameDuration;
	private float levelTime;
	private float timeOffset;


	// Use this for initialization
	void Start () {
		levelTime = 0f;
		timeOffset = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		print (Time.time);
		if ((Time.time-timeOffset) > gameDuration) {
			SceneManager.LoadScene ("EndGame");
		}
	}

	public void loadLevel(string level) {
		SceneManager.LoadScene(level);
	}
}
