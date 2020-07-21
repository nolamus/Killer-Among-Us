using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // for shifting scenes
using UnityEngine.UI; // for using UI element

// script to attach to player for level 1
public class ItemPickupLvl1 : MonoBehaviour
{
    public bool hasItem = false; // tracks if item was picked up
    [SerializeField] public Image itemBell; // toggles item obtained display
    // public AudioClip soundEffect;   // pickup sound effect
    // public GameObject pickupEffect; // pickup particle effect

    void OnTriggerEnter2D(Collider2D item)
    {
        // if level item is picked up, destroy and record item obtained status
        if (item.gameObject.CompareTag("Bell"))
        {
            itemBell.enabled = true;
            hasItem = true; // item obtained

            Destroy(item.gameObject);
            //AudioSource.PlayClipAtPoint(soundEffect, transform.position);
            //Instantiate(pickupEffect, transform.position, type+particleeffectname)
        }

        // challenge first checkpoint, player does not have item; initiate challenge
        if (item.gameObject.CompareTag("Challenge_noItem"))
        {
            // if player does not have item, start challenge
            if(hasItem == false)
            {
                // enable falling objects
                // ** -----------> add code for commencing falling objects
                
            }

            Destroy(item.gameObject);
        }

        // challenge second checkpoint, challenge begins for item user; initiate challenge
        if (item.gameObject.CompareTag("Challenge_Item"))
        {
            // enable falling objects
            // ** -----------> add code for commencing falling objects
            if(hasItem == true)
            {

            }

            Destroy(item.gameObject);
        }

        // end of level reached, go to dialogue scene
        if (item.gameObject.CompareTag("DialogueScene"))
        {
            // move onto dialogue scene
            SceneManager.LoadScene("L1_Dialogue");
        }

    }

}
