﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // for shifting scenes
using UnityEngine.UI; // for using UI element

// script to attach to player for level 2
public class ItemPickupLvl2 : MonoBehaviour
{
    public bool hasItem = false; // tracks if item was picked up
    [SerializeField] public Image itemBroom; // toggles item obtained display
    [SerializeField] public Image screenOverlay; // represents dirty screen overlay
    // public AudioClip soundEffect;   // pickup sound effect
    // public GameObject pickupEffect; // pickup particle effect

    IEnumerator OnTriggerEnter2D(Collider2D item)
    {
        // if level item is picked up, destroy and record item obtained status
        if (item.gameObject.CompareTag("Broom"))
        {
            itemBroom.enabled = true;
            hasItem = true; // item obtained

            Destroy(item.gameObject);
            //AudioSource.PlayClipAtPoint(soundEffect, transform.position);
            //Instantiate(pickupEffect, transform.position, type+particleeffectname)
        }

        // challenge start checkpoint; initiates challenge based on item possession
        if (item.gameObject.CompareTag("ChallengeStart"))
        {
            // if player does not have item, start challenge
            if (hasItem == false)
            {
                // enable dirty screen challenge
                screenOverlay.enabled = true;
            }

            // otherwise, item delays challenge
            else
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

                // item expired, enable dirty screen challenge
                screenOverlay.enabled = true;
            }

            Destroy(item.gameObject);
        }

        // challenge end checkpoint; deactivate challenge
        if (item.gameObject.CompareTag("ChallengEnd"))
        {
            // enable dirty screen challenge
            screenOverlay.enabled = false;

            Destroy(item.gameObject);
        }

        // end of level reached, go to dialogue scene
        if (item.gameObject.CompareTag("DialogueScene"))
        {
            // move onto dialogue scene
            SceneManager.LoadScene("L2_Dialogue");
        }

    }
}
