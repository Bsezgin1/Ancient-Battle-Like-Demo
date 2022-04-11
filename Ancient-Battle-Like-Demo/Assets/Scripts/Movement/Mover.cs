using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour, IAction
{
    private Ray mouseRay;

    [SerializeField] private NavMeshAgent navMeshAgent;

    private void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
       
    }


    public void StartMoveAction(Vector3 destination)
    {
        GetComponent<ActionScheduler>().StartAction(this);
        MoveTo(destination);
    }
    private void MoveTo(Vector3 destination)
    {
        navMeshAgent.destination = destination;
        navMeshAgent.isStopped = false;
    }

    public void Cancel()
    {
        navMeshAgent.isStopped = true;
    }
}
