using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
  [SerializeField] Transform respawnPoint;

  void OnCollisionEnter2d(Collision2D col){
    if(col.transform.CompareTag("Player"))
      col.transform.position = respawnPoint.position;
  }
}
