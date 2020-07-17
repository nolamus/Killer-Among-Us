/*
 * Project: Killer Among Us 
 * This script was initially created by Joseph Ene
 */
// Handles doors perform a scene transition to rooms that can hold Key GameObjects
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyDoor : MonoBehaviour
{
    public static bool RevealKey;
    public bool IsKeyRoom;
    public bool ReturnToPreviousRoom;
    public static bool ReturnFromAnotherRoom;
    public static Vector3 PreviousPlayerPosition;
    public string BehindDoorSceneName;
    public string PreviousSceneName;
    public static int DeactivateLevelTwoKeyDoor = 0;
    public GameObject PlayerObject;
    public CapsuleCollider2D playerCollider;
    public CompositeCollider2D NoKeyDoor;
    // Start is called before the first frame update
    private void Start()
    {
        NoKeyDoor = GetComponent<CompositeCollider2D>();
    }


    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Lvl2Tracker = " + je_Door.Lvl2KeyTracker.ToString());
        if (Input.GetButtonDown("Submit") && NoKeyDoor.IsTouching(playerCollider))
        {
            //Debug.Log("GameObject2 collided with " + playerCollider.name);
            OpenLevelDoor();
        }
    }

    public void OpenLevelDoor()
    {
        RevealKey = IsKeyRoom;


        if (ReturnToPreviousRoom)
        {
            ReturnFromAnotherRoom = true;
            Debug.Log("Moving Player to position: " + PreviousPlayerPosition);
            SceneManager.LoadScene(PreviousSceneName);

        }
        else
        {
            //DontDestroyOnLoad(PlayerObject);
            PreviousPlayerPosition = PlayerObject.transform.position;
            SceneManager.LoadScene(BehindDoorSceneName);
        }

    }
}
