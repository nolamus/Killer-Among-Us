using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// attach script to player
public class GhostDialogueLvl1 : MonoBehaviour
{
    public GameObject text1;

    // text objects will be named text#
    // ghost objects will have box collider and is Trigger = true; create wide box collider

    void Start()
    {
        // text1 = object with name "text1"
        text1 = GameObject.Find("text1");
        text1.gameObject.SetActive(false);
    }

    // displays text is player is in range of ghost
    void OnTriggerEnter2D(Collider2D ghost)
    {
        // text1 displays for ghost with tag "Ghost1"
        if (ghost.gameObject.CompareTag("Ghost1"))
        {
            text1.gameObject.SetActive(true);
        }
    }

    // hides text if player is not in range of ghost
    private void OnTriggerExit2D(Collider2D ghost)
    {
        // text1 hides for ghost with tag "Ghost1"
        if (ghost.gameObject.CompareTag("Ghost1"))
        {
            text1.gameObject.SetActive(false);
        }
    }
}
