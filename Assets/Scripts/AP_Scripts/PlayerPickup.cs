using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // for shifting scenes
using UnityEngine.UI; // for using UI element

// backup script

/*
// script for player and item interaction
public class PlayerPickup : MonoBehaviour
{
    //public bool hasItem = false; // tracks if item was picked up
    [SerializeField] private Image screenOverlay; // represents dirty screen overlay


    public void Start()
    {

    }

    public bool ItemPickedUp(GameObject obj)
    {
        switch (obj.tag) // cases represent tag of object
        {
            // item for level 1
            case "Broom": 
                //hasItem = true; // item obtained
                return true;

            // trigger for entering challenge with no item
            case "Challenge1_noItem":
                //hasItem = false;
                //DirtyScreen(hasItem);
                return true;

            // trigger for entering challenge with item
            case "Challenge1_Item":
               // hasItem = true;
                //DirtyScreen(hasItem);
                return true;

            // scene trigger for level 1
            case "Scene_LevelOne":
                SceneOne();
                return true;

            default:
                return false;
        }
    }

    private void SceneOne()
    {
        //SceneManager.LoadScene(" ");
    }


    public void DirtyScreen(bool val)
    {
        // if no item exists
        if(val == false)
        {
            screenOverlay.enabled = true;
        }

    }
}
*/