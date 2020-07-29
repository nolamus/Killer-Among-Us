using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinkingPlatform : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float fallDelay;
    [SerializeField] float resetTimer = 5f;
    private Rigidbody2D platform;
    private Vector3 startPos;


    void Start()
    {
        platform = GetComponent<Rigidbody2D>();
        startPos = transform.position;
    }

    /*void Update()
    {
        if(!FindObjectOfType<Player>().isAlive)
            if(transform.position != startPos.position)
                transform.position = startPos.position;
    }*/

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.CompareTag("Player"))
            StartCoroutine(Fall());
    }

    IEnumerator Fall()
    {
        yield return new WaitForSeconds(fallDelay);
        platform.isKinematic = false;
        yield return new WaitForSeconds(resetTimer);
        transform.position = startPos;
        platform.isKinematic = true;

        yield return 0;
    }

}
