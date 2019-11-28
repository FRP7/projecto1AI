using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachineMain : MonoBehaviour
{
    public GameObject goal1;
    public GameObject goal11;
    public GameObject goal2;
    public GameObject goal22;
    public GameObject goal0;
    public GameObject goal00;
    //public GameObject goal4;
    public NavMeshAgent agent;
    public int State;
    // Start is called before the first frame update
    void Start() {
        goal1 = GameObject.Find("goal1");
        goal11 = GameObject.Find("goal11");
        goal2 = GameObject.Find("goal2");
        goal22 = GameObject.Find("goal22");
        goal0 = GameObject.Find("goal0");
        goal00 = GameObject.Find("goal00");
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
        //agent.destination = goal11.transform.position;
        int rndrestaurante;
        rndrestaurante = Random.Range(1, 4);
        //Debug.Log(rndrestaurante);
        if(rndrestaurante > 2) {
            agent.destination = goal11.transform.position;
        } else if(rndrestaurante < 2) {
            agent.destination = goal1.transform.position;
        }
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
