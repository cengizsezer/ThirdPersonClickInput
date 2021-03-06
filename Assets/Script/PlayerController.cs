using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    //Animator animator;
    NavMeshAgent agent;

    void Awake()
    {
        //animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        //animator.SetFloat("Speed", agent.velocity.magnitude);
    }

    public void SetDestination(Vector3 destination)
    {
        agent.destination = destination;
    }
}
