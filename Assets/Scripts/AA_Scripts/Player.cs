using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour
{
    //Config
    [SerializeField] float runSpeed = 5f;
    [SerializeField] float jumpSpeed = 5f;
    [SerializeField] float climbSpeed = 5f;

    //Local variables
    private bool isAlive = true;

    //Cached component references
    Rigidbody2D playerRigidBody;
    Animator playerAnimator;
    CapsuleCollider2D bodyCollider;             
    BoxCollider2D feetCollider;                 //Collider to determine if feet are touching ground to prevent wall jumps
    SpriteRenderer playerSprite;                //used to change character color apon death

    void Start()    //grab components from player
    {
        playerRigidBody = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
        bodyCollider = GetComponent<CapsuleCollider2D>();
        feetCollider = GetComponent<BoxCollider2D>();
        playerSprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if(!isAlive)        //if player is dead, disable player control
            return;

        Run();
        Jump();
        Climb();
        flipSprite();
        Death();
    }

    private void Run()
    {
        float controlRun = CrossPlatformInputManager.GetAxis("Horizontal"); // [-1,1] allows for us to use input regardless of platform
        Vector2 runVelocity = new Vector2(controlRun * runSpeed, playerRigidBody.velocity.y);       //create a new position of the speed/direction the player is moving
        playerRigidBody.velocity = runVelocity;                                                     

        bool playerHasHorizontalSpeed = Mathf.Abs(playerRigidBody.velocity.x) > Mathf.Epsilon;      //checks if player is moving
        playerAnimator.SetBool("Running", playerHasHorizontalSpeed);                                //Triggers run animation
    }

    private void Jump()
    {
        if(CrossPlatformInputManager.GetButtonDown("Jump") && feetCollider.IsTouchingLayers(LayerMask.GetMask("Foreground"))) //make sure the player is touching the ground before jumping  
        {
            Vector2 jumpVelocity = new Vector2(0f, jumpSpeed);
            playerRigidBody.velocity += jumpVelocity;
        }
    }

    private void Climb()
    {
        if(!bodyCollider.IsTouchingLayers(LayerMask.GetMask("Climbing")))   //if player isn't touching ladder return
            return;

        float controlClimb = CrossPlatformInputManager.GetAxis("Vertical");
        Vector2 climbVelocity = new Vector2(playerRigidBody.velocity.x, controlClimb * climbSpeed);
        playerRigidBody.velocity = climbVelocity;
    }

    private void Death()
    {
        if(bodyCollider.IsTouchingLayers(LayerMask.GetMask("Enemy", "Hazard"))) //if player is touching enemy layer
        {
            isAlive = false;
            playerAnimator.SetTrigger("Dying");                 //players death animation
            playerSprite.color = new Color(1, 0, 0, 1);         //set color to red when player dies
            Time.timeScale = 0f;            
        }
    }

    private void flipSprite()
    {
        //if player is moving horizontally then flip or reverse current scaling of x axis
        bool playerHasHorizontalSpeed = Mathf.Abs(playerRigidBody.velocity.x) > Mathf.Epsilon; //greater than 0 IE if player is moving
        if(playerHasHorizontalSpeed)
        {
            if(Mathf.Sign(playerRigidBody.velocity.x) > 0)
                transform.localScale = new Vector2(1f, 1f); //- left or + right
            else
                transform.localScale = new Vector2(-1f, 1f); //- left or + right 
        }
    }


}
