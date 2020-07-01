using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// script for player and item interaction
public class PlayerPickup : MonoBehaviour
{
    public int Activated;

    public bool ItemPickedUp(GameObject obj)
    {
        switch (obj.tag)
        {
            // item for level 1
            case "Broom": // tagged Broom
                Activated++;
                return true;

            // scene trigger for level 1
            case "Scene_LevelOne": // tagged Scene_LevelOne
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

}
