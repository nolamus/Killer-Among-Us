/*
 * Project: Killer Among Us 
 * This script was initially created by Joseph Ene
 */
// Handles Interactions with doors that restrict access to ladders
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class je_Door : MonoBehaviour
{

    //public static bool ReturnFromAnotherRoom;
    //public string BehindDoorSceneName;
    //public bool ReturnToPreviousRoom;
    //public string PreviousSceneName;
    public bool LadderRoomDoor;
    //public static bool RevealKey;
    //public bool IsKeyRoom;
    public static int Lvl2KeyTracker = 0;
    public int Lvl2KeyPermission;
    
    //public static Vector3 PreviousPlayerPosition;
    public Sprite DoorOpen;
    public Sprite DoorClosed;
    public SpriteRenderer Door;
    public GameObject PlayerObject;
    public GameObject OtherDoor;
    //public CapsuleCollider2D playerCollider;
    //public CompositeCollider2D NoKeyDoor;


    // Start is called before the first frame update
    void Start()
    {
        Door = GetComponent<SpriteRenderer>();
        //Lvl2KeyTracker = 1; Use Only During Testing
        
    }

    // Update is called once per frame
    /*void Update()
    {
        Debug.Log("Lvl2Tracker = "+Lvl2KeyTracker.ToString());
        if (Input.GetButtonDown("Submit")  && NoKeyDoor.IsTouching(playerCollider))
        {
            //Debug.Log("GameObject2 collided with " + playerCollider.name);
            OpenLevelDoor();
        }
    }*/

    void OnMouseDown()
    {
        // Unlocks or Opens the Door blocking the way to the ladder to the next floor
        Debug.Log("MouseDown");
        if (LadderRoomDoor)
        {
            if (Lvl2KeyTracker == 1 || Lvl2KeyTracker == 3 || Lvl2KeyTracker == 5 || Lvl2KeyTracker == 7)
            {
                UnlockLvl2LadderDoor();
            }
            else if (Lvl2KeyTracker >= Lvl2KeyPermission)
            {
                OpenLvl2Ladder();
            }

        } 
    }
    /*public void OpenLevelDoor()
    {
        RevealKey = IsKeyRoom;
        
        
        if(ReturnToPreviousRoom)
        {
            ReturnFromAnotherRoom = true;
            Debug.Log("Moving Player to position: " + je_Door.PreviousPlayerPosition);
            SceneManager.LoadScene(PreviousSceneName);
           
        }
        else
        {
            //DontDestroyOnLoad(PlayerObject);
            PreviousPlayerPosition = PlayerObject.transform.position;
            SceneManager.LoadScene(BehindDoorSceneName);
        }
        
    }*/

    // Unlocks door blocking the ladders on Level 2
    public void UnlockLvl2LadderDoor()
    {
        Debug.Log("Ladder Unlocked");
        /*
         * Lvl2KeyTracker == 0 means the no keys have been found
         * Lvl2KeyTracker == 1 key to ladder room of floor 1 has been found
         * Lvl2KeyTracker == 3 key to ladder room of floor 2 has been found
         * Lvl2KeyTracker == 5 key to ladder room of floor 3 has been found
         * Lvl2KeyTracker == 7 key to boss room of floor 4 has been found
         * Lvl2KeyTracker == 2,4,6,or 8 means that the door below it have been unlocked
         */
        Door.sprite = DoorOpen;
        Lvl2KeyTracker++; // Signal that the door has been unlocked
    }

    // Opens door blocking the ladders on Level 2
    public void OpenLvl2Ladder()
    {
        Debug.Log("Ladder Door Used");
        PlayerObject.transform.position = OtherDoor.transform.position;
        
    }
}
