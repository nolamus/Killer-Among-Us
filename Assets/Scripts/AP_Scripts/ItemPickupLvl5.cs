using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // for shifting scenes
using UnityEngine.UI; // for using UI element

// script to attach to player for level 5
public class ItemPickupLvl5 : MonoBehaviour
{
    public bool hasItem = false; // tracks if item was picked up
    [SerializeField] public Image itemBell; // toggles item obtained display
    public AudioClip soundEffect;   // pickup sound effect

    void OnTriggerEnter2D(Collider2D item)
    {
        // if level item is picked up, destroy and record item obtained status
        if (item.gameObject.CompareTag("Bell"))
        {
            itemBell.enabled = true; // item obtained image on Canvas
            hasItem = true; // item obtained
            //AudioSource.PlayClipAtPoint(soundEffect, transform.position);
            Destroy(item.gameObject);
            
        }

        // challenge first checkpoint, player does not have item; initiate challenge
        if (item.gameObject.CompareTag("Challenge_noItem"))
        {
            // if player does not have item, start challenge
            if (hasItem == false)
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
            if (hasItem == true)
            {

            }

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
