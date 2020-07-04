using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float minDelay = 1f;
    [SerializeField] float maxDelay = 5f;
    [SerializeField] Projectile projectileType;
    [SerializeField] float despawnDelay = 5f;
    
    bool spawn = true;
    IEnumerator Start()
    {
        while(spawn)
        {
            yield return new WaitForSeconds(Random.Range(minDelay, maxDelay)); 
            spawnProjectile();
            //yield return new WaitForSeconds(despawnDelay);
            //Destroy(projectileType);
        }

    }

    private void spawnProjectile()
    {
        Instantiate(projectileType, transform.position, transform.rotation);    
    }
}
