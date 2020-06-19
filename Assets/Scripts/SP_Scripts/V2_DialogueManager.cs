using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This method for running the dialogue in the text-based scene was not used

public class V2_DialogueManager : MonoBehaviour
{
    // Keeps track of all sentences in current dialogue as a queue (FIFO)
    private Queue<string> sentences;
    
    // Start is called before the first frame update
    void Start()
    {
        // initialize queue
        sentences = new Queue<string>();
    }
}
