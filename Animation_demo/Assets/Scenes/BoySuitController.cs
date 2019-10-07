using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoySuitController : MonoBehaviour {
    Rigidbody2D myRigidBody;
    public float speed;
    public Animator myAnimator;
    bool keyDown;
    float xpos;

    // Start is called before the first frame update
    void Awake () {
        myRigidBody = GetComponent<Rigidbody2D> ();
        myAnimator = GetComponent<Animator> ();
    }

    // Update is called once per frame
    void Update () {
        keyDown = Input.GetKeyDown (KeyCode.Space);
        xpos = Input.GetAxis ("Horizontal");

        if (keyDown) {
            explosion ();
        } else {
            horizMotion ();
        }
    }

    void explosion () {
        myAnimator.SetBool ("isExplode", true);
    }

    void horizMotion () {
        if (xpos >.5f) {
            myAnimator.SetBool ("isRunning", true);
            transform.localScale = new Vector3 (1f, 1f, 1f);
            transform.position += new Vector3 (xpos, 0f, 0f) * speed * Time.deltaTime;
        } else if (xpos < -.5f) {
            myAnimator.SetBool ("isRunning", true);
            transform.localScale = new Vector3 (-1f, 1f, 1f);
            transform.position += new Vector3 (xpos, 0f, 0f) * speed * Time.deltaTime;
        } else { // idle
            myAnimator.SetBool ("isRunning", false);
        }
    }

    void resetPosition () {
        myAnimator.SetBool ("isExplode", false);
        transform.position = new Vector3 (1.2f, -.62f, 0f);
    }
}