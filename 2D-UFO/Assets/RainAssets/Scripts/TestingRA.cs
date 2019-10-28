using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingRA : MonoBehaviour {
	GameObject obj;

	void Awake () {
		obj = this.gameObject;
		print (obj.name + ": awake");
	}

	// Enable occurs after Awake for any given object, and it seems  that the 
	// pair Awake/OnEnable for one object occurs before the pair for the next object
	void OnEnable () {
		print (obj.name + ": onEnable");
	}

	// Use this for initialization
	void Start () {
		print (obj.name + ": Start");
	}

	void FixedUpdate () {
		print (obj.name + ": FixedUpdate");
	}

	// Update is called once per frame
	void Update () {
		print (obj.name + ": Update");
	}

	void LateUpdate () {
		print (obj.name + ": LateUpdate");
	}

	void OnWillRenderObject () {
		print (obj.name + ": OnWillRenderObject");
	}

	void OnPreCull () {
		print (obj.name + ": OnPreCull");
	}

	void OnBecameVisible () {
		print (obj.name + ": OnBecameVisible");
	}

	void OnBecameInvisible () {
		print (obj.name + ": OnBecameInvisible");
	}

	void OnPreRender () {
		print (obj.name + ": OnPreRender");
	}

	void OnRenderObject () {
		print (obj.name + ": OnRenderObject");
	}

	void OnPostRender () {
		print (obj.name + ": OnPostRender");
	}

	//	void OnRenderImage() {
	//		print (obj.name + ": OnRenderImage");
	//	}

	void OnDrawGizmos () {
		print (obj.name + ": OnDrawGizmos");
	}

	void OnGUI () {
		print (obj.name + ": OnGUI");
	}

	// Not called it seems
	void OnApplicationPause () {
		print (obj.name + ": OnApplicationPause");
	}

	void OnDisable () {
		print (obj.name + ": OnDisable");
	}

	void OnApplicationQuit () {
		print (obj.name + ": OnApplicationQuit");
	}

	void OnDestroy () {
		print (obj.name + ": OnDestroy");
		print ("---------------------\n");
	}

}