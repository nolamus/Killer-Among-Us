using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
  //public Vector3 respawnPoint;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 horizontal = new Vector3(Input.GetAxis("Horizontal"), 0.0f, 0.0f);
        transform.position = transform.position + horizontal * Time.deltaTime;
    }
  /*  void OnTriggerEnter2D(Collider2D other){
      if(other.tag == "Respawn"){
        transform.position = respawnPoint;
      }

    } */
}
