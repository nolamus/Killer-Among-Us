using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // for shifting scenes

public class TransitionLvl0 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D item)
    {
        // end of level reached, go to dialogue scene
        if (item.gameObject.CompareTag("DialogueScene"))
        {
            // move onto dialogue scene
            SceneManager.LoadScene("Intro_Dialogue");
        }
    }
}
