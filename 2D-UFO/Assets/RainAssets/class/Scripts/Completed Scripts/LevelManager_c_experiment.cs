using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager_c_experiment : MonoBehaviour {
	public Button turnOffBackground;
	public GameObject background;
	public Text backgroundText;

	// Use this for initialization
	void Start () {
		//backgroundText = turnOffBackground.GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void TurnOffBackground() {
		if (background.activeSelf) {
			print (backgroundText);
			backgroundText.text = "Turn on Background";
			background.SetActive (false);
		} else {
			background.SetActive (true);
			backgroundText.text = "Turn off Background"; 
		}
	}
}
