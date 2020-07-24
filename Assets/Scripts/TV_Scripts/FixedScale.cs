using System.Collections;
  using System.Collections.Generic;
  using UnityEngine;

  [ExecuteInEditMode]
  public class FixedScale : MonoBehaviour {
   public Vector3 scale;
   public float FixeScaleX ;
   public float FixeScaleY;
   public float FixeScaleZ;
   Transform parent;

 void Start(){
  scale = transform.localScale;
             FixeScaleX = scale.x;
             FixeScaleY = scale.y;
             FixeScaleZ = scale.z;
 }
      // Update is called once per frame
      void Update () {
          transform.localScale = new Vector3 (FixeScaleX/parent.transform.localScale.x,FixeScaleY/parent.transform.localScale.y,FixeScaleZ/parent.transform.localScale.z);

              }
          }
