using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // for shifting scenes
using UnityEngine.UI; // for using UI element

public class ItemPickupLvl3 : MonoBehaviour
{
    public bool hasItem = false; // tracks if item was picked up
    [SerializeField] public Image itemFlashlight; // toggles item obtained display
    [SerializeField] public Image darkOverlay; // represents dirty screen overlay
    // public AudioClip soundEffect;   // pickup sound effect
    // public GameObject pickupEffect; // pickup particle effect

    IEnumerator OnTriggerEnter2D(Collider2D item)
    {
        // if level item is picked up, destroy and record item obtained status
        if (item.gameObject.CompareTag("Flashlight"))
        {
            itemFlashlight.enabled = true;
            hasItem = true; // item obtained

            Destroy(item.gameObject);
            //AudioSource.PlayClipAtPoint(soundEffect, transform.position);
            //Instantiate(pickupEffect, transform.position, type+particleeffectname)
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

                // item expired, enable challenge
            }

            // challenge end checkpoint; deactivate challenge
            while (!item.gameObject.CompareTag("ChallengeEnd"))
            {
                // lights flicker on and off randomly
                darkOverlay.enabled = false;
                yield return new WaitForSeconds(Random.Range(1, 5));
                darkOverlay.enabled = true;
                yield return new WaitForSeconds(Random.Range(1, 5));
            }
            
            Destroy(item.gameObject);
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
