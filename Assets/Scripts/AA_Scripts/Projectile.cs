using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float projectileSpeed = 5f;
    
    void update()
    {
        transform.Translate(Vector2.down * projectileSpeed * Time.deltaTime);
    }
}
