using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipSprite : MonoBehaviour
{
   // variable to hold a reference to our SpriteRenderer component
   private SpriteRenderer mySpriteRenderer;

    // This function is called just one time by Unity the moment the component loads
    private void Start()
    {
        // get a reference to the SpriteRenderer component on this gameObject
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        mySpriteRenderer.flipX = true;
    }
}
