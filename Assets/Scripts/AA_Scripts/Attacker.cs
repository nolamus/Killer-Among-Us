﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    [Range(0f, 5f)]
    float currentSpeed = 1f;
    
    void Update()
    {
        transform.Translate(Vector2.left * currentSpeed * Time.deltaTime);
    }

    public void setMovementSpeed(float speed)
    { currentSpeed = speed; }
}
