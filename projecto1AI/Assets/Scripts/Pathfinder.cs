using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pathfinder : MonoBehaviour
{
    public GameObject goal1;
    public GameObject goal2;
    public GameObject goal3;
    //public GameObject goal4;
    public NavMeshAgent agent;
    public int State;
    // Start is called before the first frame update
    void Start() {
        goal1 = GameObject.Find("goal1");
        goal2 = GameObject.Find("goal2");
        goal3 = GameObject.Find("goal3");
        agent = GameObject.FindWithTag("Agent").GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void FixedUpdate() {
        //agent.destination = goal2.transform.position;
        switch (State) {
            case 1:
                Restaurante();
                break;
            case 2:
                Jardim();
                break;
            default:
                Concerto();
                break;
        }
    }

    public void Restaurante() {
        agent.destination = goal1.transform.position;
        return;
    }
    public void Jardim() {
        agent.destination = goal2.transform.position;
        return;
    }

    public void Concerto() {
        agent.destination = goal3.transform.position;
        return;
    }
	
}
