using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// This script is a template for one way to implement scene transitions
// This method was not used, but instead incorporated into the script used for the on-screen buttons

public class SwitchScenes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Check to see if the spacebar is pressed
        if(Input.GetKeyDown(KeyCode.Space))
        {
            // Load next scene for transition
            SceneManager.LoadScene("Dialogue_Zero_V2");
        }
    }
}
