using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ExplosionBehaviour : MonoBehaviour
{
    public StateMachineMain STMinstance;
    public NavMeshAgent NavMeshinstance;

    //fugir a explosão
    public GameObject Agent;
    public GameObject Bomb;
    //

    private void Start() {
        STMinstance = gameObject.GetComponent<StateMachineMain>();
        NavMeshinstance = gameObject.GetComponent<NavMeshAgent>();
    }

    public void Explosion() {
        Debug.Log("Explodindo");
    }
}
