using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    private Transform target;
    private NavMeshAgent agent;
    private float timer;

    public float wanderRadius;
    public float wanderTimer;

    public CubeS cubeS;
    public CubeM cubeM;
    public CubeL cubeL;

    void OnEnable()
    {
        agent = GetComponent<NavMeshAgent>();
        timer = wanderTimer;
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= wanderTimer)
        {
            Vector3 newPos = RandomNavSphere(transform.position, wanderRadius, -1);
            agent.SetDestination(newPos);
            timer = 0;
        }
    }

    public static Vector3 RandomNavSphere(Vector3 origin, float dist, int layermask)
    {
        Vector3 randDirection = Random.insideUnitSphere * dist;

        randDirection += origin;

        NavMeshHit navHit;

        NavMesh.SamplePosition(randDirection, out navHit, dist, layermask);

        return navHit.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("CubeS"))
        {
            cubeS.Death();
        }

        if (other.CompareTag("CubeM"))
        {
            cubeM.Death();
        }

        if (other.CompareTag("CubeL"))
        {
            cubeL.Death();
        }
    }
}
