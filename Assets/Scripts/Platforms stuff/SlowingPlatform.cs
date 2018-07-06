using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowingPlatform : MonoBehaviour
{
    public float dragAmount = 1f;

    private float normalSpeed;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {

            PlayerController pc = col.gameObject.GetComponent<PlayerController>();
            normalSpeed = pc.moveSpeed;
            pc.moveSpeed = dragAmount;
        }
    }

    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {

            PlayerController pc = col.gameObject.GetComponent<PlayerController>();
            pc.moveSpeed = normalSpeed;
        }
    }
}
