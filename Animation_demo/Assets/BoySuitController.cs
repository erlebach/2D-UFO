using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoySuitController : MonoBehaviour {
    Rigidbody2D myRigidBody;
    public float speed;
    public Animator myAnimator;

    // Start is called before the first frame update
    void Awake () {
        myRigidBody = GetComponent<Rigidbody2D> ();
        myAnimator = GetComponent<Animator> ();
    }

    // Update is called once per frame
    void Update () {
        float xpos = Input.GetAxis ("Horizontal");
        print (xpos);
        if (xpos >.5f) {
            myAnimator.SetBool ("isRunning", true);
            transform.localScale = new Vector3 (1f, 1f, 1f);
            //print ("< 0");
        } else if (xpos < -.5f) {
            myAnimator.SetBool ("isRunning", true);
            transform.localScale = new Vector3 (-1f, 1f, 1f);
            //print ("> 0");
        } else {
            myAnimator.SetBool ("isRunning", false);
            //transform.localScale = new Vector3 (1f, 1f, 1f);
        }
        transform.position += new Vector3 (xpos, 0f, 0f) * speed * Time.deltaTime;
    }
}