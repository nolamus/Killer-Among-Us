
using UnityEngine;
// Remember that this is a script made by Anika
// Rename it once anika files have been merged with the branch
public class je_PlayerCtrl : MonoBehaviour
{

    bool isGrounded;

    //[SerializeField]
    //Transform groundCheck;


    Animator animator;
    Rigidbody2D rb;
    SpriteRenderer spRender;

    private Rigidbody2D rigidBody;
    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        spRender = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {

        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb.velocity = new Vector2(-5, rb.velocity.y);
            animator.Play("Player_run"); // player movement to left animation name
            spRender.flipX = true;
        }
        else if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rb.velocity = new Vector2(5, rb.velocity.y);
            animator.Play("Player_run"); // player movement to right animation name
            spRender.flipX = false;
        }
        else
        {
            rb.velocity = new Vector2(0, 0);
            animator.Play("Player_idle");
        }

        if (Input.GetKey("space") /*&& isGrounded == true*/)
        {
            rb.velocity = new Vector2(rb.velocity.x, 3);
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse);
            animator.Play("Player_jump");
        }

    }
}
