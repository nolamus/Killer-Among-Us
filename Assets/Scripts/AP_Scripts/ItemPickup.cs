using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// script for item
public class ItemPickup : MonoBehaviour
{
    // public AudioClip soundEffect;   // pickup sound effect
    // public GameObject pickupEffect; // pickup particle effect

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerPickup forItem = collision.GetComponent<PlayerPickup>();

        // if item is picked up, destroy
        if (forItem)
        {
            bool pickedUp = forItem.ItemPickedUp(gameObject);

            if (pickedUp)
            {
                RemoveItem();
            }

        }
    }


    // add in dummy/invisible object to trigger scene change

    private void RemoveItem()
    {
        Destroy(gameObject);
        //AudioSource.PlayClipAtPoint(soundEffect, transform.position);
        //Instantiate(pickupEffect, transform.position, type+particleeffectname)
    }
}
