using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pathfinder : MonoBehaviour
{
    public GameObject goal1;
    public GameObject goal2;
    public GameObject goal3;
    public NavMeshAgent agent;
    // Start is called before the first frame update
    void Start() {
        goal1 = GameObject.Find("goal1");
        goal2 = GameObject.Find("goal2");
        goal2 = GameObject.Find("goal3");
        agent = GameObject.FindWithTag("Agent").GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update() {
        //agent.destination = goal2.transform.position;
    }

    public void Restaurante() {
        agent.destination = goal1.transform.position;
    }
    public void Jardim() {
        agent.destination = goal2.transform.position;
    }

    public void Concerto() {
        agent.destination = goal3.transform.position;
    }
}
