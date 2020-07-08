using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostDialogue : MonoBehaviour
{
    // create a rectangular space to detect player approaching ghost
    void OnTriggerEnter2D(Collider2D item)
    {
        if (item.gameObject.CompareTag("BackGhost"))
        {
            // trigger text to show up
        }
    }

    // create a rectangular space to detect player leaving ghost
    void OnTriggerExit2D(Collider2D item)
    {
        if (item.gameObject.CompareTag("BackGhost"))
        {
            // trigger text to turn off
        }
    }
}
