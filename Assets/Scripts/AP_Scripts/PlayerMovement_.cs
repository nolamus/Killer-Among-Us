using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement_ : MonoBehaviour
    
{/*
    private Rigidbody2D rb;         // object for player movement

    private bool moveLeft;          // bool for left button
    private bool moveRight;         // bool for right button
    private bool moveUp;            // bool for jump button

    private float horizontalMove;   // holds value for horizontal movement
    public float speedX = 5;        // speed for left + right movements

    private float verticalMove;     // holds value for vertical movement
    public float speedY = 5;        // speed for up movement

    bool isAlive = true;            // From AA Player Script
    Animator playerAnimator;
    CapsuleCollider2D bodyCollider;
    [SerializeField] Vector2 deathLaunch = new Vector2(1f, 1f);


    // Start is called before the first frame update
    void Start()
    {
        // sets up object + defaults
        rb = GetComponent<Rigidbody2D>();

        playerAnimator = GetComponent<Animator>();  // From AA Player Script
        bodyCollider = GetComponent<CapsuleCollider2D>();  // From AA Player Script

        moveLeft = false;
        moveRight = false;
        moveUp = false;
    }

    // ------------- Left Button Action -------------

    // pressing down on left button
    public void PointerDownLeft()
    {
        moveLeft = true;
    }

    // default left button (not pressing)
    public void PointerUpLeft()
    {
        moveLeft = false;
    }


    // ------------- Right Button Action ------------- 

    // pressing down on right button
    public void PointerDownRight()
    {
        moveRight = true;
    }

    // default right button (not pressing)
    public void PointerUpRight()
    {
        moveRight = false;
    }


    // ------------- Jump Button Action ------------- 

    // pressing down on jump button
    public void PointerDownJump()
    {
        moveUp = true;
    }

    // default jump button (not pressing)
    public void PointerUpJump()
    {
        moveUp = false;
    }


    // Update is called once per frame
    void Update()
    {
        if (!isAlive)        //if player is dead, disable player control
            return;         // From AA Player Script

        MovementPlayer();
        Death(); // From AA Player Script
    }

    // speed value assigning based on button action
    private void MovementPlayer()
    {
        // left + up button
        if (moveLeft && moveUp)
        {
            horizontalMove = -speedX;    // horizontal speed is (-)
            verticalMove = speedY;       // vertical speed is (+)
        }

        // right + up button
        else if (moveRight && moveUp)
        {
            horizontalMove = speedX;     // horizontal speed if (+)
            verticalMove = speedY;       // vertical speed is (+)
        }

        // left + right button
        else if (moveLeft && moveRight)
        {
            horizontalMove = 0;           // no horizontal
            verticalMove = 0;             // no vertical
        }

        // left button
        else if (moveLeft)
        {
            horizontalMove = -speedX;    // horizontal speed is (-)
            verticalMove = 0;            // no vertical
        }

        // right button
        else if (moveRight)
        {
            horizontalMove = speedX;     // horizontal speed is (+)
            verticalMove = 0;            // no vertical
        }

        // jump button
        else if (moveUp)
        {
            horizontalMove = 0;          // no horizontal
            verticalMove = speedY;       // vertical speed is (+)
        }

        // no button
        else
        {
            horizontalMove = 0;         // no horizontal
            verticalMove = 0;           // no vertical
        }
    }

    // player movement based on button action
    private void FixedUpdate()
    {
        if (rb.velocity.y == 0) // can only jump once
        {
            // for vertical axis movement ; up movement
            rb.velocity = new Vector2(rb.velocity.x, verticalMove); // (default horizontal, set vertical)
        }

        // for horizontal axis movement ; left/right movement
        rb.velocity = new Vector2(horizontalMove, rb.velocity.y); // (set horizontal, default vertical)

    }


    // From AA Player Script
    private void Death()
    {
        if (bodyCollider.IsTouchingLayers(LayerMask.GetMask("Enemy", "Hazard"))) //if player is touching enemy layer
        {
            isAlive = false;
            playerAnimator.SetTrigger("Dying");
            GetComponent<Rigidbody2D>().velocity = deathLaunch;
        }
    }*/
}