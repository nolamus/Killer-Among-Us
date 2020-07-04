using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private float spawnTime;
    public float spawnDelay = 5f;
    BoxCollider2D projectile;

    private void Start()
    { projectile = GetComponent<BoxCollider2D>(); }   
    
    private void update()
    {
        if(projectile.IsTouchingLayers(LayerMask.GetMask("Foreground", "Player")))
            Destroy(gameObject);
    }
}
