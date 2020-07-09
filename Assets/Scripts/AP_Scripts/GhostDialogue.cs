using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // for text component

public class GhostDialogue : MonoBehaviour
{
    public Text ghostText;

    // create a rectangular space to detect player approaching ghost
    void OnTriggerEnter2D(Collider2D item)
    {
        if (item.gameObject.CompareTag("Player"))
        {
            ghostText.gameObject.SetActive(true);
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
