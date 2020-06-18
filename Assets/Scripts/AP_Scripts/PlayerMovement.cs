using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;         // object for player movement

    private bool moveLeft;          // bool for left button
    private bool moveRight;         // bool for right button
    private bool moveUp;            // bool for jump button
    private bool moveNext;          // bool for next button

    private float horizontalMove;   // holds value for horizontal movement
    public float speedX = 5;        // speed for left + right movements

    private float verticalMove;     // holds value for vertical movement
    public float speedY = 5;        // speed for up movement

    bool Left;
    bool Right;

    bool isAlive = true;            // From AA Player Script
    Animator playerAnimator;
    CapsuleCollider2D bodyCollider;
    public SpriteRenderer spRender;
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
        moveNext = false;
        Left = false;
        Right = false;
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

    // ------------- Next Button Action ------------- 

    // pressing down on right button
    public void PointerDownNext()
    {
        moveNext = true;
    }

    // default right button (not pressing)
    public void PointerUpNext()
    {
        moveNext = false;
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
            Left = true;
            spRender.flipX = true;
        }

        // right + up button
        else if (moveRight && moveUp)
        {
            horizontalMove = speedX;     // horizontal speed if (+)
            verticalMove = speedY;       // vertical speed is (+)
            Right = true;
            spRender.flipX = false;
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
            Left = true;
            spRender.flipX = true;
        }

        // right button
        else if (moveRight)
        {
            horizontalMove = speedX;     // horizontal speed is (+)
            verticalMove = 0;            // no vertical
            Right = true;
            spRender.flipX = true;
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

        // next button
        if(moveNext)
        {
            SceneManager.LoadScene("Dialogue_Zero_V1");
        }
    }

    // player movement based on button action
    private void FixedUpdate()
    {

        // for horizontal axis movement ; left/right movement
        if (Left && moveUp)
        {
            rb.velocity = new Vector2(horizontalMove, rb.velocity.y); // (set horizontal, default vertical)
            if (rb.velocity.y == 0) // can only jump once
            {
                // for vertical axis movement ; up movement
                rb.velocity = new Vector2(rb.velocity.x, verticalMove); // (default horizontal, set vertical)
                playerAnimator.Play("Player_Jump");
                spRender.flipX = true;
            }
        }

        if (Right && moveUp)
        {
            rb.velocity = new Vector2(horizontalMove, rb.velocity.y); // (set horizontal, default vertical)
            if (rb.velocity.y == 0) // can only jump once
            {
                // for vertical axis movement ; up movement
                rb.velocity = new Vector2(rb.velocity.x, verticalMove); // (default horizontal, set vertical)
                playerAnimator.Play("Player_Jump");
                spRender.flipX = false;
            }
        }

        if (moveUp)
        {
            if (rb.velocity.y == 0) // can only jump once
            {
                // for vertical axis movement ; up movement
                rb.velocity = new Vector2(rb.velocity.x, verticalMove); // (default horizontal, set vertical)
                playerAnimator.Play("Player_Jump");
            }
        }

        // for horizontal axis movement ; left/right movement
        if(Left)
        {
            spRender.flipX = true;
            rb.velocity = new Vector2(horizontalMove, rb.velocity.y); // (set horizontal, default vertical)
            playerAnimator.Play("Player_Walk");
            

        }

        if (Right)
        {
            spRender.flipX = false;
            rb.velocity = new Vector2(horizontalMove, rb.velocity.y); // (set horizontal, default vertical)
            playerAnimator.Play("Player_Walk");
            

        }

        playerAnimator.Play("Player_Idle");

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
    }
}
