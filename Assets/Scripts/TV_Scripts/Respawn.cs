using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;
    private int lives = 3;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other){
        if(other.name == "boy" )
        {
            player.transform.position = respawnPoint.transform.position;
            lives--;
            if(lives < 0)
              SceneManager.LoadScene("je_MainMenu");
        }

    }
}
