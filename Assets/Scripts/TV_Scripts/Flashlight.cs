using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
  public bool hasItem = false;
  [SerializeField] public GameObject flashlight;
  public Light light;
  //public GameObject thePlayer;
    // Start is called before the first frame update

  void OnTriggerEnter2D(Collider2D item)
  {
    if(item.gameObject.CompareTag("Flashlight")){
      hasItem = true;
      Destroy(item.gameObject);
      light.enabled = true;
    }
  }
  void Start(){
    //light = GetComponentInChildren(Light);
    light.enabled = false;
  }
/*  void Update(){
    if(light.enabled == true)
    transform.LookAt(thePlayer.transform);
  } */
}
