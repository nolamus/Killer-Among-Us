using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // for shifting scenes
using UnityEngine.UI; // for using UI element

// script to attach to player for level 1
public class ItemPickupLvl4 : MonoBehaviour
{
    public bool hasItem = false; // tracks if item was picked up
    public bool superJump = false; // tracks if super jump can be activated
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

        // challenge first checkpoint, if player has item, allow it to aid them
        if (item.gameObject.CompareTag("Challenge_noItem"))
        {
            // if player has item, activate
            if(hasItem == true)
            {
                superJump = true;
            }

            Destroy(item.gameObject);
        }

        // challenge second checkpoint, item no longer useful, 
        if (item.gameObject.CompareTag("Challenge_Item"))
        {
            // item power de
            superJump = false;

            Destroy(item.gameObject);
        }

        // end of level reached, go to dialogue scene
        if (item.gameObject.CompareTag("DialogueScene"))
        {
            Destroy(item.gameObject);

            // move onto dialogue scene
            SceneManager.LoadScene("L#_Dialogue");
        }

    }

}
