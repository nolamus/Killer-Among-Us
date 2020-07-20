using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpike : MonoBehaviour
{
    public void Hazardous()
    {
        gameObject.layer = 18;
    }

    public void Safe()
    {
        gameObject.layer = 8;
    }
}
