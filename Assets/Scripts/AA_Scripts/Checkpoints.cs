using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoints : MonoBehaviour
{
    public Sprite redFlag;
    public Sprite greenFlag;
    private SpriteRenderer checkpointSpriteRenderer;
    public bool checkpointReached;
    private bool trigger;
    // Use this for initialization
    void Start()
    {
        checkpointSpriteRenderer = GetComponent<SpriteRenderer>();
    }
    
    void Awake() { trigger = false; }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (!trigger)
            if (collider.gameObject.layer == LayerMask.NameToLayer("Character"))
                Trigger();
    }

    void Trigger()
    {
        checkpointSpriteRenderer.sprite = greenFlag;
        checkpointReached = true;
    }
}
