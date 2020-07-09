using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Je_DestroyLevel_Two_Door : MonoBehaviour
{
    public int DoorDestroyCompareNumber;
    public GameObject KeyDoorTilemap;
    // Start is called before the first frame update
    void Start()
    {
        if(KeyDoor.DeactivateLevelTwoKeyDoor == DoorDestroyCompareNumber)
        {
            KeyDoorTilemap.GetComponent<KeyDoor>().enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
