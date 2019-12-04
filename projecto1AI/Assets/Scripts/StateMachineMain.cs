using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachineMain : MonoBehaviour
{
    public GameObject goal1;
    public GameObject goal2;
    public GameObject goal0;
    public GameObject goal00;
    public NavMeshAgent agent;
    public int State;

    //palco
    int palco;
    //

    void Start() {
        goal1 = GameObject.Find("goal1");
        goal2 = GameObject.Find("goal2");
        goal0 = GameObject.Find("goal0");
        goal00 = GameObject.Find("goal00");
        agent = gameObject.GetComponent<NavMeshAgent>();
        //palco 
        palco = Random.Range(0, 2);
        //
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
        ///sorteia qual é o palco que vai
        if(palco > 0) {
            agent.destination = goal0.transform.position;
        }
        if(palco == 0) {
            agent.destination = goal00.transform.position;
        }
        return;
    }
	
}
