using UnityEngine;
using System;
using System.Collections;

public class Ghost_Float : MonoBehaviour
{
    float originalY;

    public float floatStrength = 1; // changes floating level of ghost, can also
                                    //manually change in unity

    void Start()
    {
        this.originalY = this.transform.position.y;

    }

    void Update()
    {
        transform.position = new Vector3(transform.position.x,
            originalY + ((float)Math.Sin(Time.time) * floatStrength),
            transform.position.z); //makes ghost float!!
    }
}
