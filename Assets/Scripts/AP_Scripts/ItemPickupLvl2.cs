using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // for shifting scenes
using UnityEngine.UI; // for using UI element

// script to attach to player for level 2
public class ItemPickupLvl2 : MonoBehaviour
{
    Collision other;
    bool aliveStatus; // tracks alive status of player
    bool inChallenge = false; // tracks if player has entered challenge area
    public bool hasItem = false; // tracks if item was picked up
    [SerializeField] public Image itemBroom; // toggles item obtained display
    [SerializeField] public Image screenOverlay; // represents dirty screen overlay
    public AudioClip soundEffect;   // pickup sound effect

    private void Update()
    {
        // if player dies within challenge, item is gone
        aliveStatus = gameObject.GetComponent<Player>().isAlive;
        if (aliveStatus == false && inChallenge == true)
        {
            inChallenge = false;

            if (hasItem == true)
            {
                hasItem = false;
                Destroy(itemBroom.gameObject);
            }
        }
    }

    IEnumerator OnTriggerEnter2D(Collider2D item)
    {
        // if level item is picked up, destroy and record item obtained status
        if (item.gameObject.CompareTag("Broom"))
        {
            itemBroom.enabled = true; // item obtained image on Canvas
            hasItem = true; // item obtained

            Destroy(item.gameObject);
            AudioSource.PlayClipAtPoint(soundEffect, transform.position);
        }

        // challenge start checkpoint; initiates challenge based on item possession
        if (item.gameObject.CompareTag("ChallengeStart"))
        {
            // if player has item, delay challenge
            if (hasItem == true)
            {
                yield return new WaitForSeconds(7);

                // item expiring, warning 1
                yield return new WaitForSeconds(1);
                itemBroom.enabled = false;
                yield return new WaitForSeconds(1);
                itemBroom.enabled = true;

                // item expiring, warning 2
                yield return new WaitForSeconds(1);
                itemBroom.enabled = false;
                yield return new WaitForSeconds(1);
                itemBroom.enabled = true;

                // item expiring, warning 3
                yield return new WaitForSeconds(1);
                itemBroom.enabled = false;
                yield return new WaitForSeconds(1);
                itemBroom.enabled = true;
                yield return new WaitForSeconds(1);
                itemBroom.enabled = false;

                hasItem = false; // item can only be used once
            }

            inChallenge = true;

            // enable dirty screen
            screenOverlay.enabled = true;

        }

        // challenge end checkpoint; deactivate challenge
        if (item.gameObject.CompareTag("ChallengeEnd"))
        {
            // enable dirty screen challenge
            screenOverlay.enabled = false;
            Destroy(screenOverlay.gameObject);
            Destroy(item.gameObject);
        }

        // end of level reached, go to dialogue scene
        if (item.gameObject.CompareTag("DialogueScene"))
        {
            je_MainMenu.Lvl2Cleared = true;
            // move onto dialogue scene
            SceneManager.LoadScene("L2_Dialogue");
        }

    }

}
