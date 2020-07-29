using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // for shifting scenes
using UnityEngine.UI; // for using UI element

// script to attach to player for level 5
public class ItemPickupLvl5 : MonoBehaviour
{
    public bool hasItem = false; // tracks if item was picked up

    public bool superJump = false; // tracks if super jump can be activated
    [SerializeField] public Image itemShoe; // toggles item obtained display
    public AudioClip soundEffect;   // pickup sound effect


    IEnumerator OnTriggerEnter2D(Collider2D item)
    {
        // if level item is picked up, destroy and record item obtained status
        if (item.gameObject.CompareTag("Shoe"))
        {
            itemShoe.enabled = true; // item obtained image on Canvas
            hasItem = true; // item obtained
            AudioSource.PlayClipAtPoint(soundEffect, transform.position);
            Destroy(item.gameObject);
            
        }

        // challenge start checkpoint; initiates challenge based on item possession
        if (item.gameObject.CompareTag("ChallengeStart"))
        {
            // if player has item, activate helper
            if (hasItem == true)
            {
                superJump = true;

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
                itemShoe.enabled = false;
            }

            // item expired, helper deactivates

            superJump = false;

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
