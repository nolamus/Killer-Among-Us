using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float minDelay = 1f;
    [SerializeField] float maxDelay = 5f;
    [SerializeField] float despawnDelay = 1.0f;     
    public GameObject projectileType;               //object which will be spawned
    
    bool spawn = true;
    IEnumerator Start()
    {
        while(spawn)
        {
            yield return new WaitForSeconds(Random.Range(minDelay, maxDelay));      //random spawning
            spawnProjectile();
        }

    }

    private void spawnProjectile()
    {
        GameObject clone = (GameObject)Instantiate(projectileType, transform.position, transform.rotation);         //clones gameobject and instantiates in game
        Destroy (clone, despawnDelay);              //delete gameobject after despawnDelay seconds
    }
}
