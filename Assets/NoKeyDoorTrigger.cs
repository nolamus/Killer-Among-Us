using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoKeyDoorTrigger : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.CompareTag("NoKeyDoor"))
        {
            Debug.Log("GameObject2 collided with " + col.name);
        }
    }
}
