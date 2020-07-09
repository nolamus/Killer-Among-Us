/*
 * Project: Killer Among Us 
 * This script was initially created by Joseph Ene
 */
// Prevents the Script on the Tilemaps for each floors key from activating more than once
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Je_DestroyLevel_Two_Door : MonoBehaviour
{
    // Identifies which tilemap script to disable
    public int DoorDestroyCompareNumber; 
    public GameObject KeyDoorTilemap;
    // Start is called before the first frame update
    void Start()
    {
        if(KeyDoor.DeactivateLevelTwoKeyDoor == DoorDestroyCompareNumber)
        {
            KeyDoorTilemap.GetComponent<KeyDoor>().enabled = false;
        }
    }

    
}
