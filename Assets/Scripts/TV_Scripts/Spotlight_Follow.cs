using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spotlight_Follow : MonoBehaviour
{
  public Flashlight flashlight;
  public GameObject thePlayer;
    // Start is called before the first frame update
    void Start()
    {
        flashlight = FindObjectOfType<Flashlight>(); //finds the player in unity
    }

    // Update is called once per frame
    void Update()
    {
      if(flashlight.light.enabled == true)
        transform.LookAt(thePlayer.transform);
    }
}
