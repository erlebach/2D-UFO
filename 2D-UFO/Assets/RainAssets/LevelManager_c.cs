using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager_c : MonoBehaviour {

	public GameObject background;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void DisableBackground() {
		if (background.activeSelf) {
			background.SetActive (false);
		} else {
			background.SetActive (true); 
		}

	}
}
