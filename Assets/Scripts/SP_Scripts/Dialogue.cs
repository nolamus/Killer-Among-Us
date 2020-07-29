using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// This is the main script for running the dialogue in scene "Dialogue_Zero_V1"
// However, this script is no longer being used for the game as "Intro_Dialogue"
    // is being used in place of "Dialogue_Zero_V1"

public class Dialogue : MonoBehaviour
{
    // Graphical user interface access
    public TextMeshProUGUI textDisplay;
    // Holds all sentences that make up dialogue
    public string[] sentences;
    // Tracking current sentence
    private int index;
    // Variable for typing effect delay
    public float typingSpeed;

    // Prevent garbage text
    public GameObject continueButton;

    // Start is called before the first frame update   
    void Start()
    {
        StartCoroutine(Type());
    }

    // Update is called once per frame    
    void Update()
    {
        // Check if display text is equal to current sentence
        if(textDisplay.text == sentences[index])
        {
            continueButton.SetActive(true);
        }
    }

    // Co-routine: Acts as a function, but code doesn't need to be run immediately
    IEnumerator Type()
    {
        // Cool typing effect
        foreach (char letter in sentences[index].ToCharArray())
        {
            // Add single letter to text display
            textDisplay.text += letter;
            // Wait a couple milliseconds
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    // Call on next sentences for display
    public void NextSentence()
    {
        // Prevent button spamming
        continueButton.SetActive(false);
        
        // Reset display for next sentence
        if(index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        // Reset display after sentences are done
        else
        {
            textDisplay.text = "";
        }
    }
}
