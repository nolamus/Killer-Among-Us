using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class NoKeyDoorTrigger : MonoBehaviour
{
    public CompositeCollider2D NoKeyDoor;
    public CapsuleCollider2D playerCollider;

    void Update()
    {
        //NoKeyFound();
    }
    void NoKeyFound()
    {
        if(NoKeyDoor.IsTouching(playerCollider))
        {
            Debug.Log("GameObject2 collided with " + playerCollider.name);
        }
    }

    
}
