using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NewBehaviourScript : MonoBehaviour
{

    public NavMeshAgent agent;
    public GameObject hero;
    
    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(hero.transform.position);
    }
}
