using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float xCoordinate = .5f;
    [SerializeField] float yCoordinate = .5f;
    [SerializeField] float zCoordinate = .5f;
    [SerializeField] float speedMultiplier = 1/400f;

    float currentSpeed = 1f;
    private Vector3 diagonally;

    
    void Update()
    {
        diagonally = new Vector3(xCoordinate,yCoordinate,zCoordinate); 
        transform.Translate(diagonally * speedMultiplier); //currentSpeed * Time.deltaTime
    }

    public void setMovementSpeed(float speed)
    { currentSpeed = speed; }
}
