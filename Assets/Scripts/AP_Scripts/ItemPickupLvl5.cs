using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // for shifting scenes
using UnityEngine.UI; // for using UI element

// script to attach to player for level 5
public class ItemPickupLvl5 : MonoBehaviour
{
    bool aliveStatus; // tracks alive status of player
    bool inChallenge = false; // tracks if player has entered challenge area
    public bool hasItem = false; // tracks if item was picked up
    public bool superSpeed = false; // tracks if super speed can be activated
    [SerializeField] public Image itemShoe; // toggles item obtained display
    public AudioClip soundEffect; // pickup sound effect

    private void Update()
    {
        // if player dies within challenge, item is gone
        aliveStatus = gameObject.GetComponent<Player>().isAlive;
        if (aliveStatus == false && inChallenge == true && hasItem == true)
        {
            hasItem = false;
            superSpeed = false;
            inChallenge = false;
            Destroy(itemShoe.gameObject);
        }
    }

    IEnumerator OnTriggerEnter2D(Collider2D item)
    {
        // if level item is picked up, destroy and record item obtained status
        if (item.gameObject.CompareTag("Shoe"))
        {
            Destroy(item.gameObject);
            itemShoe.enabled = true; // item obtained image on Canvas
            hasItem = true; // item obtained
//<<<<<<< HEAD
            //AudioSource.PlayClipAtPoint(soundEffect, transform.position);
            Destroy(item.gameObject);

//=======


            AudioSource.PlayClipAtPoint(soundEffect, transform.position);
//>>>>>>> 084e56211a0ff0f613b3d3df3e10c7096edfd5a6
        }

        // challenge start checkpoint; initiates challenge based on item possession
        if (item.gameObject.CompareTag("ChallengeStart"))
        {
            inChallenge = true; // player has entered challenge area

            // if player has item, activate helper
            if (hasItem == true)
            {
                superSpeed = true; // activate super speed

                yield return new WaitForSeconds(7);

                // item expiring, warning 1
                yield return new WaitForSeconds(1);
                itemShoe.enabled = false;
                yield return new WaitForSeconds(1);
                itemShoe.enabled = true;

                // item expiring, warning 2
                yield return new WaitForSeconds(1);
                itemShoe.enabled = false;
                yield return new WaitForSeconds(1);
                itemShoe.enabled = true;

                // item expiring, warning 3
                yield return new WaitForSeconds(1);
                itemShoe.enabled = false;
                yield return new WaitForSeconds(1);
                itemShoe.enabled = true;
                yield return new WaitForSeconds(1);

                superSpeed = false; // super speed expired
                hasItem = false; // item can only be used once
            }

            // item expired, helper deactivates
            Destroy(itemShoe.gameObject);
            Destroy(item.gameObject);
        }

        // end of level reached, go to dialogue scene
        if (item.gameObject.CompareTag("DialogueScene"))
        {
            je_MainMenu.Lvl5Cleared = true;
            Debug.Log("Lvl5Cleared");
            // move onto dialogue scene
            SceneManager.LoadScene("L5_Dialogue");
        }
    }
}
