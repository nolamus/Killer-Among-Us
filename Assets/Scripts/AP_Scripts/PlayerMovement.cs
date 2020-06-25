using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    //Serialized Fields
    [SerializeField] Vector2 deathLaunch = new Vector2(1f, 1f);
    [SerializeField] float speedX = 5f; //horizontal speed
    [SerializeField] float speedY = 5f; //vertical speed

    //Cached Components
    private Rigidbody2D rb;         // object for player movement
    Animator playerAnimator;
    CapsuleCollider2D bodyCollider;
    public SpriteRenderer spRender;

    //local variables
    private bool moveLeft;          // bool for left button
    private bool moveRight;         // bool for right button
    private bool moveUp;            // bool for jump button
    private bool moveNext;          // bool for next button

    private float horizontalMove;   // holds value for horizontal movement

    private float verticalMove;     // holds value for vertical movement

    private bool isAlive = true;            // From AA Player Script


    // Start is called before the first frame update
    void Start()
    {
        // sets up object + defaults
        rb = GetComponent<Rigidbody2D>();


        playerAnimator = GetComponent<Animator>();  // From AA Player Script
        bodyCollider = GetComponent<CapsuleCollider2D>();  // From AA Player Script
        spRender = GetComponent<SpriteRenderer>();

        moveLeft = false;
        moveRight = false;
        moveUp = false;
        moveNext = false;
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
        if (!isAlive)                           //if player is dead, disable player control
            return;                             // From AA Player Script

        MovementPlayer();
        Death();                                // From AA Player Script
    }

    // speed value assigning based on button action
    private void MovementPlayer()
    {
        // left + up button
        if (moveLeft && moveUp)
        {
            horizontalMove = -speedX;           // horizontal speed is (-)
            verticalMove = speedY;              // vertical speed is (+)
            playerAnimator.Play("playerMove");
        }

        // right + up button
        else if (moveRight && moveUp)
        {
            horizontalMove = speedX;            // horizontal speed if (+)
            verticalMove = speedY;              // vertical speed is (+)
            playerAnimator.Play("playerMove");
        }

        // left + right button
        else if (moveLeft && moveRight)
        {
            horizontalMove = 0;                 // no horizontal
            verticalMove = 0;                   // no vertical
            playerAnimator.Play("playerIdle");
        }

        // left button
        else if (moveLeft)
        {
            horizontalMove = -speedX;           // horizontal speed is (-)
            verticalMove = 0;                   // no vertical
            playerAnimator.Play("playerMove");  //enables moving when left button pressed
        }

        // right button
        else if (moveRight)
        {
            horizontalMove = speedX;            // horizontal speed is (+)
            verticalMove = 0;                   // no vertical
            playerAnimator.Play("playerMove");  //enables moving when right button pressed
        }

        // jump button
        else if (moveUp)
        {
            horizontalMove = 0;                 // no horizontal
            verticalMove = speedY;              // vertical speed is (+)
            if(bodyCollider.IsTouchingLayers(LayerMask.GetMask("Climbing")))
                playerAnimator.Play("playerClimb");
        }

        // no button
        else
        {
            horizontalMove = 0;                 // no horizontal
            verticalMove = 0;                   // no vertical
            playerAnimator.Play("playerIdle");
        }

        // next button -> loads dialogue scene
        if (moveNext)
        {
            SceneManager.LoadScene("Dialogue_Zero_V1");
        }
    }

    // player movement based on button action, runs whenever physics 
    private void FixedUpdate()
    {
        // for horizontal axis movement ; left/right movement
        rb.velocity = new Vector2(horizontalMove, rb.velocity.y);                    // (set horizontal, default vertical)
        bool playerHasHorizontalSpeed = Mathf.Abs(rb.velocity.x) > Mathf.Epsilon;    // boolean checking if player is moving
        bool playerIdle = rb.velocity.x == 0;                                        // boolean checking if player is idling
        bool playerHasVerticalSpeed = rb.velocity.y > 0;                             // boolean checking if player is midair

        if(isAlive)
        {
            //if player has no horizontal speed enable idling boolean, else enable running boolean (Animator Controller)
            if (playerHasHorizontalSpeed)                        
                playerAnimator.SetBool("Running", playerIdle);
            else
                playerAnimator.SetBool("Idling", playerHasHorizontalSpeed);

            //Ladders
            if (bodyCollider.IsTouchingLayers(LayerMask.GetMask("Climbing")))
                playerAnimator.SetBool("playerClimb", playerHasVerticalSpeed);
            else
                playerAnimator.SetBool("Idling", playerIdle);
 
            //responds to left input, ensures gravity mid air
            // (default horizontal, set vertical)
            if (bodyCollider.IsTouchingLayers(LayerMask.GetMask("Foreground")) && moveLeft)     
            {
                rb.velocity = new Vector2(rb.velocity.x, verticalMove); 
                spRender.flipX = true;
            }

            if (playerHasVerticalSpeed && moveLeft)                          //flips sprite if left or right pressed mid-air
            {
                rb.velocity = new Vector2(rb.velocity.x, verticalMove); 
                spRender.flipX = true;
            }

            if (playerHasVerticalSpeed && moveRight)                         //flips sprite if left or right pressed mid-air
            {
                rb.velocity = new Vector2(rb.velocity.x, verticalMove); 
                spRender.flipX = false;
            }

            //responds to right input, ensures gravity mid air
            if (bodyCollider.IsTouchingLayers(LayerMask.GetMask("Foreground")) && moveRight)
            {
                rb.velocity = new Vector2(rb.velocity.x, verticalMove); 
                spRender.flipX = false;
            }
            
            //if user input is up, check if we're on a ladder layer or just on the foreground to determine behavior and animation
            if (moveUp)
                if (bodyCollider.IsTouchingLayers(LayerMask.GetMask("Climbing")) || bodyCollider.IsTouchingLayers(LayerMask.GetMask("Foreground")))
                    rb.velocity = new Vector2(rb.velocity.x, verticalMove);


        }
        else
            rb.velocity = new Vector2(0f, 0f);                          //ensures player won't move if isAlive == false
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

    /*private void Climb()
    {
        if(!bodyCollider.IsTouchingLayers(LayerMask.GetMask("Climbing"))) return;
        else
        {
            float controlThrow = 
        }
    }*/
}
