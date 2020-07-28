/*
 * Project: Killer Among Us 
 * This script was initially created by Joseph Ene
 */
// Manages Key GameObject responses to User Interaction 
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class je_KeyManager : MonoBehaviour
{

    public GameObject Key;
    public GameObject NotificationPanel;
    public BoxCollider2D KeyCollider;
    public CapsuleCollider2D playerCollider;
    public TextMeshProUGUI ObtainedKeyMessage;
    public bool IsLevelTwo;
    // Start is called before the first frame update
    void Start()
    {
        KeyCollider = GetComponent<BoxCollider2D>();
        NotificationPanel.SetActive(false);
        Debug.Log("Is level 2 is: " + IsLevelTwo);
        
        /*DEPRECATED
         * if (KeyDoor.RevealKey)
        {
            Key.SetActive(true);
        }
        else
        {
            Key.SetActive(false);
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        // Allows User to Collect a Key Using The Submit Button
        // TODO: The Submit Button is still not responding to this condition
        if (Input.GetButtonDown("Submit") && KeyCollider.IsTouching(playerCollider))
        {
            ObtainKey();
        }

        
    }

    // Enables User to Collect a Key using a Mouse Click
    void OnMouseDown()
    {
        ObtainKey();
    }

    /* Informs User that the key has been obtained
     * Increments Tracker that determines what keys have been obtained
     * Destroys Key Object*/
    private void ObtainKey()
    {
        if (IsLevelTwo)
        {
            KeyDoor.DeactivateLevelTwoKeyDoor++;
            Debug.Log("Deactivated Level Two Key Door: " + KeyDoor.DeactivateLevelTwoKeyDoor);

        }

        je_Door.Lvl2KeyTracker++; 
        Destroy(Key);
        NotificationPanel.SetActive(true);
        Destroy(NotificationPanel, 2f);
    }
}
