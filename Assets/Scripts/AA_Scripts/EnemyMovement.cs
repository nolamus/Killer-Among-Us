using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1f;
    
    //Component caching
    Rigidbody2D enemyRB;

    void Start()    //grab Rigidbody2d Component to implement collisions
    {
        enemyRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(facingRight())   //if false, flip direction
            enemyRB.velocity = new Vector2(moveSpeed, 0f);
        else
            enemyRB.velocity = new Vector2(-moveSpeed, 0f);
    }

    private bool facingRight()  //return true if enemy facing right
    {
        return transform.localScale.x > 0;
    }

    private void OnTriggerExit2D(Collider2D collision)    //if enemy detects collision, flip localScale to have him move the opposite direction
    {
        transform.localScale = new Vector2(-(Mathf.Sign(enemyRB.velocity.x)), 1f);
    }
}
