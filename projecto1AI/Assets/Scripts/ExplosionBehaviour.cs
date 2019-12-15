using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ExplosionBehaviour : MonoBehaviour
{
    public StateMachineMain STMinstance;
    public NavMeshAgent NavMeshinstance;
    
    public GameObject Agent;
    public GameObject Bomb;
    public GameObject Exits;

    private void Start() {
        STMinstance = gameObject.GetComponent<StateMachineMain>();
        NavMeshinstance = gameObject.GetComponent<NavMeshAgent>();
    }

    public void Explosion() {
        NavMeshinstance.destination = Exits.transform.position;
    }
}
