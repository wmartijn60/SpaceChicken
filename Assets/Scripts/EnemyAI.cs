

using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public SpriteRenderer enemy;
    public float speed = 1.19f;
   // public Vector3 pointA;
    //public Vector3 pointB;
    public Vector3 pointA;
    public Vector3 pointB;
    

    // start
    private void Start()
    {
        enemy = GetComponent<SpriteRenderer>();

        // punten waar tussen de enemy heen en weer gaat
        pointA = new Vector3((float)5.75, (float)-1.25, 0);
        pointB = new Vector3((float)10, (float)-1.25, 0);
    }

    // update
    private void Update()
    {
        
        //PingPong tussen 0 and 1
        float time = Mathf.PingPong(Time.time * speed, 1);
        transform.position = Vector3.Lerp(pointA, pointB, time);
    }
}