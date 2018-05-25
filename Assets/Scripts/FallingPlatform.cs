using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{


    private Rigidbody2D rb2d;

    public float fallDelay;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
           
            StartCoroutine(Fall());
        }
    }

    IEnumerator Fall()
    {
        yield return new WaitForSeconds(fallDelay);
        rb2d.isKinematic = false;

        StartCoroutine(ExecuteAfterTime(0.5f));

        //GetComponent<Collider2D>().isTrigger = true;
       // yield return 0;
    }
    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        GetComponent<Collider2D>().isTrigger = true;
        yield return 0;
        // Code to execute after the delay
    }
}