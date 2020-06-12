using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    [SerializeField] float minSpawnDelay = 1f; //You use the SerializeField attribute when you need your variable to be private but also want it to show up in the Editor.
    [SerializeField] float maxSpawnDelay = 5f;
    [SerializeField] Attacker attackerPrefab;
    bool spawn = true;
    IEnumerator Start() //Ienum - creates start as a coroutine 
    {
        while(spawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));        //waits within the range 1-5 on random intervals
            spawnAttacker();
        }
    }

    private void spawnAttacker()
    {
       Instantiate(attackerPrefab, transform.position, transform.rotation); //looks for an object to assign (line 9)
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
