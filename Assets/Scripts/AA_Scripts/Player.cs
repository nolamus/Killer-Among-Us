using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.SceneManagement;

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
    private GameSession session;
    public Vector3 respawnPoint;


    void Start()    //grab components from player
    {
        playerRigidBody = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
        bodyCollider = GetComponent<CapsuleCollider2D>();
        feetCollider = GetComponent<BoxCollider2D>();
        playerSprite = GetComponent<SpriteRenderer>();
        session = FindObjectOfType<GameSession>();

    }

    void Update()
    {
        if(!isAlive || je_PauseMenu.isPaused)        //if player is dead or player pauses, disable player control
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
//<<<<<<< HEAD
            /*if (gameObject.GetComponent<ItemPickupLvl4>().superJump == true)
                jumpSpeed = 10f;
            else
                jumpSpeed = 5f;*/
//=======
            // checks if scene matches Level 4 to account for challenge
            Scene L4Scene;
            string sceneName;
            L4Scene = SceneManager.GetActiveScene();
            sceneName = L4Scene.name;

            // level 4 super jump
            if (sceneName == "AA_Level_Four")
            {
                // if item has been obtained, use super jump
                if (gameObject.GetComponent<ItemPickupLvl4>().superJump == true)
                    jumpSpeed = 10f;

                // if no item or item has expired, regular jump
                else
                    jumpSpeed = 8f;
            }
//>>>>>>> fb8375feb59812c9cfa14f022dac3f2dabac0d62

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
      if(bodyCollider.IsTouchingLayers(LayerMask.GetMask("Enemy", "Hazard", "RollingBoulders"))) //if player is touching enemy layer
        {
            //if(session.lives < 1)
                //isAlive = false;
            //playerAnimator.SetTrigger("Dying");                 //players death animation
            //playerSprite.color = new Color(1, 0, 0, 1);         //set color to red when player dies
            //Time.timeScale = 0f;
            //FindObjectOfType<GameSession>().ProcessPlayerDeath();
            //session.ProcessPlayerDeath();

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

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Hazards")
        {
            transform.position = respawnPoint;
            FindObjectOfType<GameSession>().ProcessPlayerDeath();
        }
        if (collider.tag == "Checkpoint")
        {
            respawnPoint = collider.transform.position;
        }
    }



}
