using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other){
        if(other.name == "boy" )
        {
            player.transform.position = respawnPoint.transform.position;
        }
        
      
    }
}
