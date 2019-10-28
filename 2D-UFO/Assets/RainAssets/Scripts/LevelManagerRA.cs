using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManagerRA : MonoBehaviour {
	public Scene nextLevel;
	// Static variable: one per class
	static string currentScene;

	// Use this for initialization
	void Start () {
		//print ("Start, Inside LevelManager, lastLevelPlayed: " + lastLevelPlayed);
		currentScene = SceneManager.GetActiveScene ().name;
		print ("Start, currentSCene= " + currentScene);
	}

	// Update is called once per frame
	void Update () { }

	public void NextLevel () {
		//print ("inside NextLevel(),  lastLevelPlayed: " + lastLevelPlayed);
		// hardcoding is not the best practice
		if (currentScene == "_Menu") {
			SceneManager.LoadScene ("Level01");
		} else if (currentScene == "Level01") {
			SceneManager.LoadScene ("Level02");
		} else if (currentScene == "Level02") {
			SceneManager.LoadScene ("Game Won");
		}
	}

	// function overload
	// not currently used
	public void NextLevel (string level) {
		print (">> NextLevel: about to LoadScene: " + level);
		SceneManager.LoadScene (level);
	}

	public void QuitGame () {
		print ("Quit Game");
		Application.Quit ();
	}
}