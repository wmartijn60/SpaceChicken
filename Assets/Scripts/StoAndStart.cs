using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoAndStart : MonoBehaviour
{
    private ParticleSystem ps;

    private bool isGrounded = true;
	// Use this for initialization
	void Start ()
	{
	    ps = GetComponent<ParticleSystem>();
	    ps.Play();
	}
	
	// Update is called once per frame
	void Update ()
	{
	    bool groundCheck = GameObject.Find("Player").GetComponent<PlayerController>().grounded;

        if (isGrounded != groundCheck)
        {
            isGrounded = groundCheck;


            if (!isGrounded)
            {

                ps.Stop();
                ParticleSystem.EmissionModule emit = ps.emission;
                emit.rateOverDistanceMultiplier = 0f;

                //Debug.Log("jumping");
                //ps.simulationSpace = ParticleSystemSimulationSpace.Local;
            }
            else
            {
                //Debug.Log("landing");
                //ps.simulationSpace = ParticleSystemSimulationSpace.World;
                ps.Play();
                ParticleSystem.EmissionModule emit = ps.emission;
                emit.rateOverDistanceMultiplier = 1f;
            }

        }


	}
}
