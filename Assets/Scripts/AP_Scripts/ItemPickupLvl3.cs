using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // for shifting scenes
using UnityEngine.UI; // for using UI element

// script to attach to player for level 3
public class ItemPickupLvl3 : MonoBehaviour
{
    bool inChallenge = false;
    bool lightsOn = false;
    public bool hasItem = false; // tracks if item was picked up
    [SerializeField] public Image itemFlashlight; // toggles item obtained display
    [SerializeField] public Image darkOverlay; // represents dirty screen overlay
     public AudioClip soundEffect;   // pickup sound effect

    IEnumerator OnTriggerEnter2D(Collider2D item)
    {
        // if level item is picked up, destroy and record item obtained status
        if (item.gameObject.CompareTag("Flashlight"))
        {
            itemFlashlight.enabled = true; // item obtained image on Canvas
            hasItem = true; // item obtained

            Destroy(item.gameObject);
            AudioSource.PlayClipAtPoint(soundEffect, transform.position);
        }

        // challenge start checkpoint; initiates challenge based on item possession
        if (item.gameObject.CompareTag("ChallengeStart"))
        {
            inChallenge = true;

            Destroy(item.gameObject);
        }

        if (!item.gameObject.CompareTag("ChallengeStart") && inChallenge == true && lightsOn == false)
        {
            // if player has item, delay challenge
            if (hasItem == true)
            {
                yield return new WaitForSeconds(7);

                // item expiring, warning 1
                yield return new WaitForSeconds(1);
                itemFlashlight.enabled = false;
                yield return new WaitForSeconds(1);
                itemFlashlight.enabled = true;

                // item expiring, warning 2
                yield return new WaitForSeconds(1);
                itemFlashlight.enabled = false;
                yield return new WaitForSeconds(1);
                itemFlashlight.enabled = true;

                // item expiring, warning 3
                yield return new WaitForSeconds(1);
                itemFlashlight.enabled = false;
                yield return new WaitForSeconds(1);
                itemFlashlight.enabled = true;
                yield return new WaitForSeconds(1);
                itemFlashlight.enabled = false;

                hasItem = false;

                // item expired, enable challenge
            }

            // challenge end checkpoint; deactivate challenge
            while (!item.gameObject.CompareTag("ChallengeEnd"))
            {
                // lights flicker on and off randomly
                darkOverlay.enabled = false;
                yield return new WaitForSeconds(Random.Range(2, 5));
                darkOverlay.enabled = true;
                yield return new WaitForSeconds(Random.Range(2, 5));
            }

            darkOverlay.enabled = false;
            lightsOn = true;

            Destroy(item.gameObject);
        }
        
        // end of level reached, go to dialogue scene
        if (item.gameObject.CompareTag("DialogueScene"))
        {
            je_MainMenu.Lvl3Cleared = true;
            // move onto dialogue scene
            SceneManager.LoadScene("L3_Dialogue");
        }

    }
}
