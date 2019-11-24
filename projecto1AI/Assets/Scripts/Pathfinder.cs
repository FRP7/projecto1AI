using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pathfinder : MonoBehaviour
{
    public GameObject goal;
    public NavMeshAgent agent;
    // Start is called before the first frame update
    void Start() {
        goal = GameObject.FindWithTag("goal");
        agent = GameObject.FindWithTag("Agent").GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update() {
        agent.destination = goal.transform.position;
    }
}
