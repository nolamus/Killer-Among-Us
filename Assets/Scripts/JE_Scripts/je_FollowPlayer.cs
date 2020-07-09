/*
 * Project: Killer Among Us 
 * This script was initially created by Joseph Ene
 */
// Forces the camera to update is position as the player is moving keeping the player within the camera's frame
using UnityEngine;

public class je_FollowPlayer : MonoBehaviour
{
    public Transform player; // Binds to the Transform component of the player character game object
    public Vector3 offset = new Vector3(0, 0, -10); // Initializes offset to camera Z position of -10

    void Start()
    {
        if (KeyDoor.ReturnFromAnotherRoom)
        {
            Debug.Log("Checked for returning from another room");
            Debug.Log("Update: PreviousPosition is: " + KeyDoor.PreviousPlayerPosition);
            player.position = KeyDoor.PreviousPlayerPosition;   // Position player in location from before changing scenes
            KeyDoor.ReturnFromAnotherRoom = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        //else
        //{
            transform.position = player.position + offset; // Update the position of the object to the position of the player
        //}
        
        
    }
}
