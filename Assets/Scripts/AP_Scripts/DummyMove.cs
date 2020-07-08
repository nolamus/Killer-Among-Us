using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// keyboard script for player testing
public class DummyMove : MonoBehaviour
{
    Animator animator;
    Rigidbody2D rb;
    private float moveSpeed = 3;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        // creates constant movement rate, values below are for the left/right keys
        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb.velocity = new Vector2(-2, rb.velocity.y); // not overriding vertical action with .y
        }

        else if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rb.velocity = new Vector2(2, rb.velocity.y);
        }

        else
        {
            rb.AddForce(new Vector2(0, 0));
        }


        if (Input.GetKey("space"))
        {
            rb.velocity = new Vector2(rb.velocity.x, 3);
        }

    }
}
