using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// attach script to player
public class GhostDialogueLvl0 : MonoBehaviour
{
    public GameObject Text1;
    public GameObject Text2;
    //public GameObject Text3;
    //public GameObject Text4;
    //public GameObject Text5;

    // text objects will be named Text#
    // ghost objects will have box collider and is Trigger = true; create wide box collider
    // when script is attached to player, drag respective Text# objects to Text# slots in player inspector under GhostDialogue script

    void Start()
    {
        // text1 = object with name "text1"
        Text1 = GameObject.Find("Text1");
        Text1.gameObject.SetActive(false);

        Text2 = GameObject.Find("Text2");
        Text2.gameObject.SetActive(false);
        /*
        Text3 = GameObject.Find("Text3");
        Text3.gameObject.SetActive(false);

        Text4 = GameObject.Find("Text4");
        Text4.gameObject.SetActive(false);

   
        Text5 = GameObject.Find("Text5");
        Text5.gameObject.SetActive(false);*/
    }

    // displays text is player is in range of ghost
    void OnTriggerEnter2D(Collider2D ghost)
    {
        // text1 displays for ghost with tag "Ghost1"
        if (ghost.gameObject.CompareTag("Ghost1"))
        {
            Text1.gameObject.SetActive(true);
        }

        if (ghost.gameObject.CompareTag("Ghost2"))
        {
            Text2.gameObject.SetActive(true);
        }
        /*
        if (ghost.gameObject.CompareTag("Ghost3"))
        {
            Text3.gameObject.SetActive(true);
        }

        if (ghost.gameObject.CompareTag("Ghost4"))
        {
            Text4.gameObject.SetActive(true);
        }

        if (ghost.gameObject.CompareTag("Ghost5"))
        {
            Text5.gameObject.SetActive(true);
        }*/
    }

    // hides text if player is not in range of ghost
    private void OnTriggerExit2D(Collider2D ghost)
    {
        // text1 hides for ghost with tag "Ghost1"
        if (ghost.gameObject.CompareTag("Ghost1"))
        {
            Text1.gameObject.SetActive(false);
        }

        if (ghost.gameObject.CompareTag("Ghost2"))
        {
            Text2.gameObject.SetActive(false);
        }
        /*
        if (ghost.gameObject.CompareTag("Ghost3"))
        {
            Text3.gameObject.SetActive(false);
        }

        if (ghost.gameObject.CompareTag("Ghost4"))
        {
            Text4.gameObject.SetActive(false);
        }

        if (ghost.gameObject.CompareTag("Ghost5"))
        {
            Text5.gameObject.SetActive(false);
        }*/
    }
}
