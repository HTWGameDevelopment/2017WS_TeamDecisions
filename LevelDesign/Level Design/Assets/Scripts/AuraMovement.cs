using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AuraMovement : MonoBehaviour {

    private NavMeshAgent MyAgent;
    public Transform Target;
    private float PlayerDistance;
    public GameObject Player;


    void Start()
    {
        MyAgent = GetComponent<NavMeshAgent>();
        
    }

    void Update()
    {
        PlayerDistance = Vector3.Distance(Player.transform.position, transform.position);
        if (PlayerDistance <= 3)
        {
           
            MyAgent.enabled = false;

        }
        else
        {
            MyAgent.enabled = true;
            MyAgent.SetDestination(Target.position);
           
        }
    }
}

