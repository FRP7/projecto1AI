using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class JardimBehaviour : MonoBehaviour
{
    public float wanderRadius;  //wander
    public float wanderTime;   //wander
    private Transform target;  //wander
    //private NavMeshAgent navagent;  ///wander
    private float timer; //wander
    private NavMeshObstacle myObstacle; ///afastar de outros agentes

    public Transform agentes; //flee
    public int JardimState = 2;
    public int maxSpeed; //flee

    //mudar o stopping distance
    private NavMeshAgent navagent;
    public bool isOnJardim = false;
    //public float stoppingDistance;
    public float stopdistance = 15f;
    //

    public void Start() {
        agentes = GameObject.FindWithTag("Agent").transform; //flee
        navagent = GameObject.FindWithTag("Agent").GetComponent<NavMeshAgent>(); //wander
        timer = wanderTime; //wander
        myObstacle = GetComponent<NavMeshObstacle>(); ///afastar de outros agentes
    }
    private void OnTriggerStay(Collider other) {
        if (other.gameObject.name == "jardim_col") {
            JardimState = 1;
        } 
    }

    private void OnTriggerExit(Collider other) {
        if(other.gameObject.name == "jardim_col") {
            JardimState = 2;
        }
    }

    private void FixedUpdate() {

        switch(JardimState) {
            case 1:
                isOnJardim = true;
                EvitarAgentes();
                break;
            case 2:
                //myObstacle.enabled = false; ///afastar de outros agentes
                isOnJardim = false;
                navagent.stoppingDistance = 0f;
                break;
            default:
                //myObstacle.enabled = false; ///afastar de outros agentes
                isOnJardim = false;
                navagent.stoppingDistance = 0f;
                break;
        }
    }

    public void EvitarAgentes() {

        //myObstacle.enabled = true; ///afastar de outros agentes

        /*timer += Time.deltaTime; //wander

        if(timer >= wanderTime) {
            Vector3 newPos = RandomNavSphere(transform.position, wanderRadius, -1);
            navagent.SetDestination(newPos);
            timer = 0;  //wander
        }*/

        if (isOnJardim == true) {
            //Debug.Log("Mudar a distância de paragem");
            //stoppingDistance = 15f;
            navagent.stoppingDistance = stopdistance;
        }
        /*if(isOnJardim == false) {
            navagent.stoppingDistance = 0f;
        }*/

    }

    /*public static Vector3 RandomNavSphere(Vector3 origin, float dist, int layermask) {
        Vector3 randDirection = Random.insideUnitSphere * dist;

        randDirection += origin;

        NavMeshHit navHit;

        NavMesh.SamplePosition(randDirection, out navHit, dist, layermask);

        return navHit.position;  //wander
    }*/

}
