using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour
{
    //Config
    [SerializeField] float runSpeed = 5f;
    [SerializeField] float jumpSpeed = 5f;
    [SerializeField] Vector2 deathLaunch = new Vector2(1f,1f); 

    bool isAlive = true;

    //Cached component references
    Rigidbody2D playerRigidBody;
    Animator playerAnimator;
    CapsuleCollider2D bodyCollider;
    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
        bodyCollider = GetComponent<CapsuleCollider2D>();
    }

    void Update()
    {
        if(!isAlive)        //if player is dead, disable player control
            return;

        Run();
        flipSprite();
        Death();
    }

    private void Run()
    {
        float controlThrow = CrossPlatformInputManager.GetAxis("Horizontal"); // [-1,1]
        Vector2 playerVelocity = new Vector2(controlThrow * runSpeed, playerRigidBody.velocity.y);
        playerRigidBody.velocity = playerVelocity;

        bool playerHasHorizontalSpeed = Mathf.Abs(playerRigidBody.velocity.x) > Mathf.Epsilon;
        playerAnimator.SetBool("Running", playerHasHorizontalSpeed);
    }

    private void Death()
    {
        if(bodyCollider.IsTouchingLayers(LayerMask.GetMask("Enemy", "Hazards"))) //if player is touching enemy layer
        {
            isAlive = false;
            playerAnimator.SetTrigger("Dying");
            GetComponent<Rigidbody2D>().velocity = deathLaunch;            
        }
    }


    private void flipSprite()
    {
        //if player is moving horizontally then flip or reverse current scaling of x axis
        bool playerHasHorizontalSpeed = Mathf.Abs(playerRigidBody.velocity.x) > Mathf.Epsilon; //greater than 0 IE if player is moving
        if(playerHasHorizontalSpeed)
        {
            if(Mathf.Sign(playerRigidBody.velocity.x) > 0)
                transform.localScale = new Vector2(3f, 3f); //- left or + right
            else
                transform.localScale = new Vector2(-3f, 3f); //- left or + right 
        }
    }
}
