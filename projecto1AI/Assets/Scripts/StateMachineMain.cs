using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachineMain : MonoBehaviour
{
    public GameObject goal1;
    public GameObject goal2;
    public GameObject goal0;
    public NavMeshAgent agent;
    public int State;

    void Start() {
        goal1 = GameObject.Find("goal1");
        goal2 = GameObject.Find("goal2");
        goal0 = GameObject.Find("goal0");
        agent = gameObject.GetComponent<NavMeshAgent>();
    }

    void FixedUpdate() {
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
        agent.destination = goal0.transform.position;
        return;
    }
	
}
