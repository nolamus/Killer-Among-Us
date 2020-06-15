using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1f;
    
    //Component caching
    Rigidbody2D enemyRB;

    void Start()
    {
        enemyRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(facingRight())
            enemyRB.velocity = new Vector2(moveSpeed, 0f);
        else
            enemyRB.velocity = new Vector2(-moveSpeed, 0f);
    }

    private bool facingRight()
    {
        return transform.localScale.x > 0;
    }

    private void OnTriggerExit2D(Collider2D collision)    //passing the box collider of the enemy into this function
    {
        transform.localScale = new Vector2(-(Mathf.Sign(enemyRB.velocity.x)), 1f);
    }
}
