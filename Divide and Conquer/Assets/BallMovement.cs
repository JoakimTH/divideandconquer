using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour {

    private Rigidbody2D rb2d;
    private float vertical;
    private float horizontal;
    private Vector2 position;
      
    // Use this for initialization

    void Start () { 
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.AddForce(new Vector2(25, 25));

    }
	
	// Update is called once per frame
	void Update () {
        
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
      //      rb2d = GetComponent<Rigidbody2D>();
      //      rb2d.AddForce(new Vector2(-2, -2));
        
    }
}
