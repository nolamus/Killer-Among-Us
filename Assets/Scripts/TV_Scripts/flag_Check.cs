using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flag_Check : MonoBehaviour
{
    public Sprite greenFlag;

    // Update is called once per frame
    void OnCollisionEnter2D(Collider2D obj)
    {
      if(obj.gameObject.tag == "Player")
        this.gameObject.GetComponent<SpriteRenderer>().sprite = greenFlag;
    }
}
