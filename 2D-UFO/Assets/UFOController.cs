using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOController : MonoBehaviour {
    // A public variables is visible in the inspector
    public float speed;

    // Start is called before the first frame update
    void Start () { }

    // Update is called once per frame
    void Update () {
        // Method 1
        //float xpos = transform.position.x + speed;
        //transform.position = new Vector2 (xpos, 0f);

        // Method 2
        transform.position = new Vector2 (transform.position.x + speed, 0f);
    }
}