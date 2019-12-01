using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class JardimBehaviour : MonoBehaviour
{
    public float wanderRadius;  //wander
    public float wanderTime;   //wander
    private Transform target;  //wander
    private NavMeshAgent navagent;  ///wander
    private float timer; //wander

    public Transform agentes; //flee
    public int JardimState = 2;
    public int maxSpeed; //flee

    public void Start() {
        agentes = GameObject.FindWithTag("Agent").transform; //flee
        navagent = GameObject.FindWithTag("Agent").GetComponent<NavMeshAgent>(); //wander
        timer = wanderTime; //wander
    }
    private void OnTriggerStay(Collider other) {
        if (other.gameObject.name == "goal2") {
            JardimState = 1;
        } 
    }

    private void OnTriggerExit(Collider other) {
        if(other.gameObject.name == "goal2") {
            JardimState = 2;
        }
    }

    private void FixedUpdate() {

        switch(JardimState) {
            case 1:
                EvitarAgentes();
                break;
            case 2:
                break;
            default:
                break;
        }
    }

    public void EvitarAgentes() {
        Debug.Log("Vou evitar agentes");
        Vector3 linear = Vector3.zero;
        linear = transform.position - agentes.transform.position;
        transform.Translate(linear * Time.deltaTime); ///flee

        timer += Time.deltaTime; //wander

        if(timer >= wanderTime) {
            Vector3 newPos = RandomNavSphere(transform.position, wanderRadius, -1);
            navagent.SetDestination(newPos);
            timer = 0;  //wander
        }
    }

    public static Vector3 RandomNavSphere(Vector3 origin, float dist, int layermask) {
        Vector3 randDirection = Random.insideUnitSphere * dist;

        randDirection += origin;

        NavMeshHit navHit;

        NavMesh.SamplePosition(randDirection, out navHit, dist, layermask);

        return navHit.position;  //wander
    }
}
