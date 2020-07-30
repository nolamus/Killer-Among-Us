﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // for shifting scenes
using UnityEngine.UI; // for using UI element

// script to attach to player for level 1
public class ItemPickupLvl1 : MonoBehaviour
{
    bool aliveStatus;
    bool inChallenge = false; // tracks if player has entered challenge area
    public bool hasItem = false; // tracks if item was picked up
    public bool slowTime = false; // tracks
    public bool inivicibility = false; // tracks
    [SerializeField] public Image itemWatch; // toggles item obtained display
    public AudioClip soundEffect;   // pickup sound effect

    private void Update()
    {
        // if player dies within challenge, item is gone
        aliveStatus = gameObject.GetComponent<Player>().isAlive;
        if (aliveStatus == false && inChallenge == true && hasItem == true)
        {
            hasItem = false;
            inivicibility = false;
            inChallenge = false;
            Destroy(itemWatch.gameObject);
        }
    }

    IEnumerator OnTriggerEnter2D(Collider2D item)
    {
        // if level item is picked up, destroy and record item obtained status
        if (item.gameObject.CompareTag("Watch"))
        {
            itemWatch.enabled = true; // item obtained image on Canvas
            hasItem = true; // item obtained

            Destroy(item.gameObject);
            AudioSource.PlayClipAtPoint(soundEffect, transform.position);
        }

        // challenge first checkpoint, player does not have item; initiate challenge
        if (item.gameObject.CompareTag("ChallengeStart"))
        {
            inChallenge = true; // player has entered challenge area

            // if player does not have item, start challenge
            if (hasItem == true)
            {
                inivicibility = true; // activate time slower

                yield return new WaitForSeconds(7);

                // item expiring, warning 1
                yield return new WaitForSeconds(1);
                itemWatch.enabled = false;
                yield return new WaitForSeconds(1);
                itemWatch.enabled = true;

                // item expiring, warning 2
                yield return new WaitForSeconds(1);
                itemWatch.enabled = false;
                yield return new WaitForSeconds(1);
                itemWatch.enabled = true;

                // item expiring, warning 3
                yield return new WaitForSeconds(1);
                itemWatch.enabled = false;
                yield return new WaitForSeconds(1);
                itemWatch.enabled = true;
                yield return new WaitForSeconds(1);
                itemWatch.enabled = false;

                inivicibility = false; // time slower expired
                hasItem = false; // item can only be used once
            }

            // item expired, helper deactivates
            Destroy(itemWatch.gameObject);
            Destroy(item.gameObject);
        }

        // end of level reached, go to dialogue scene
        if (item.gameObject.CompareTag("DialogueScene"))
        {
            je_MainMenu.Lvl1Cleared = true;
            Debug.Log("Lvl1Cleared");
            // move onto dialogue scene
            SceneManager.LoadScene("L1_Dialogue");
        }

    }

}
