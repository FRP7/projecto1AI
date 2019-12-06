using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachineMain : MonoBehaviour
{
    public GameObject Palco1;
    public GameObject Palco2;
    public GameObject Restaurante1;
    public GameObject Jardim1;
    public NavMeshAgent agent;
    public int State;
    
    int palco;

    void Start() {
        agent = gameObject.GetComponent<NavMeshAgent>();

        palco = Random.Range(0, 2);
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
        agent.destination = Restaurante1.transform.position;
        return;
    }
    public void Jardim() {
        agent.destination = Jardim1.transform.position;
        return;
    }

    public void Concerto() {
        ///sorteia qual é o palco que vai
        if(palco > 0) {
            agent.destination = Palco1.transform.position;
        }
        if(palco == 0) {
            agent.destination = Palco2.transform.position;
        }
        return;
    }
}
