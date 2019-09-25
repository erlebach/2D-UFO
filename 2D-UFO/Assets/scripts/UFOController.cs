using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // for GUI elements

public class UFOController : MonoBehaviour {
    // A public variables is visible in the inspector
    public float speed;
    private Rigidbody2D rigidbody;
    public Text score_reg;
    private int score;

    // Start is called before the first frame update
    void Start () {
        rigidbody = GetComponent<Rigidbody2D> ();
        //score_reg.text = "0000";
        score = 0;
    }

    void FixedUpdate () {
        //print ("gordon");
        float moveHorizontal = Input.GetAxis ("Horizontal") * speed;
        float moveVertical = Input.GetAxis ("Vertical") * speed;
        //print (speed);

        // AddForce
        rigidbody.AddForce (new Vector2 (moveHorizontal, moveVertical));
    }
    // Update is called once per frame
    void Update () {
        // Method 1
        //float xpos = transform.position.x + speed;
        //transform.position = new Vector2 (xpos, 0f);

        // Method 2
        //transform.position = new Vector2 (transform.position.x + speed, 0f);

    }

    private void OnTriggerEnter2D (Collider2D other) {
        if (other.gameObject.CompareTag ("PickUp")) {
            other.gameObject.SetActive (false); // do not destroy
            score += 1;
            print (score);
            setScore ();
        }
    }

    private void setScore () {
        score_reg.text = score.ToString ();
    }
}