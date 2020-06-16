using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

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

    void Start()
    {
        StartCoroutine(Type());
    }
    
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
        
        if(index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            textDisplay.text = "";
        }
    }
}
