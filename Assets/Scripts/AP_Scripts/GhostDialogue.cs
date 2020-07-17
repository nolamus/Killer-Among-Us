using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // for text component

public class GhostDialogue : MonoBehaviour
{

    OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            rigidbody.detectCollisions = false;
        }
    }

    // create a rectangular space to detect player leaving ghost
    void OnTriggerExit2D(Collider2D item)
    {
        if (item.gameObject.CompareTag("Player"))
        {
            ghostText.gameObject.SetActive(false);
        }
    }
}
