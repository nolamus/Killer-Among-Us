using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinkingPlatform : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float fallDelay;
    private Rigidbody2D platform;

    void Start()
    {
        platform = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.CompareTag("Player"))
            StartCoroutine(Fall());
    }

    IEnumerator Fall()
    {
        yield return new WaitForSeconds(fallDelay);
        platform.isKinematic = false;

        yield return 0;
    }

}
