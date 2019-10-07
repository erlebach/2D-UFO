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

        // No explosion while running
        if (keyDown && xpos == 0f) {
            explosion ();
        } else {
            myAnimator.SetBool ("isExplosion", false);
        }
        horizMotion ();
    }

    void explosion () {
        myAnimator.SetBool ("isExplode", true);
        System.Threading.Thread.Sleep (100);
        myAnimator.SetBool ("isExplosion", false);
        // should happen AFTER the explosion. Here it does not
        resetPosition ();

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
        // the next line would prevent explosion. (code runs during explosion)
        // So I could sleep for length of the explosion. 
        //myAnimator.SetBool ("isExplode", false);
        transform.position = new Vector3 (1.2f, -.62f, 0f);
    }
}