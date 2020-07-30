using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // for shifting scenes
using UnityEngine.UI; // for using UI element

// script to attach to player for level 1
public class ItemPickupLvl4 : MonoBehaviour
{
    bool aliveStatus; // tracks alive status of player
    bool inChallenge = false; // tracks if player has entered challenge area
    public bool hasItem = false; // tracks if item was picked up
    public bool superJump = false; // tracks if super jump can be activate
    [SerializeField] public Image itemSpring; // toggles item obtained display
    public AudioClip soundEffect;   // pickup sound effect

    private void Update()
    {
        // if player dies within challenge, item is gone
        aliveStatus = gameObject.GetComponent<Player>().isAlive;
        if(aliveStatus == false && inChallenge == true && hasItem == true)
        {
            hasItem = false;
            superJump = false;
            inChallenge = false;
            Destroy(itemSpring.gameObject);
        }
    }

    IEnumerator OnTriggerEnter2D(Collider2D item)
    {
        // if level item is picked up, destroy and record item obtained status
        if (item.gameObject.CompareTag("Spring"))
        {
            itemSpring.enabled = true; // item obtained image on Canvas
            hasItem = true; // item obtained

            Destroy(item.gameObject);
            AudioSource.PlayClipAtPoint(soundEffect, transform.position);
        }

        // challenge start checkpoint; initiates challenge based on item possession
        if (item.gameObject.CompareTag("ChallengeStart"))
        {
            inChallenge = true; // player has entered challenge area

            // if player has item, activate helper
            if (hasItem == true)
            {
                superJump = true; // activate super jump

                yield return new WaitForSeconds(7);

                // item expiring, warning 1
                yield return new WaitForSeconds(1);
                itemSpring.enabled = false;
                yield return new WaitForSeconds(1);
                itemSpring.enabled = true;

                // item expiring, warning 2
                yield return new WaitForSeconds(1);
                itemSpring.enabled = false;
                yield return new WaitForSeconds(1);
                itemSpring.enabled = true;

                // item expiring, warning 3
                yield return new WaitForSeconds(1);
                itemSpring.enabled = false;
                yield return new WaitForSeconds(1);
                itemSpring.enabled = true;
                yield return new WaitForSeconds(1);

                superJump = false; // super jump expired
                hasItem = false; // item can only be used once
            }

            // item expired, helper deactivates
            Destroy(itemSpring.gameObject);
            Destroy(item.gameObject);

        }

        // end of level reached, go to dialogue scene
        if (item.gameObject.CompareTag("DialogueScene"))
        {
            je_MainMenu.Lvl4Cleared = true;
            // move onto dialogue scene
            SceneManager.LoadScene("L4_Dialogue");
        }

    }

}
