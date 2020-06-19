/*
 * Project: Killer Among Us 
 * This script was initially created by Joseph Ene
 */
// Forces the camera to update is position as the player is moving keeping the player within the camera's frame
using UnityEngine;

public class je_FollowPlayer : MonoBehaviour
{
    public Transform player; // Binds to the Transform component of the player character game object
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset; // Update the position of the object to the position of the player
        
    }
}
