using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class JardimBehaviour : MonoBehaviour
{
    public int JardimState = 2;
    public NavMeshAgent NavAgent;
    public int[] agentnumber;
    public GameObject zona1;

    public void Start() {
        NavAgent = GetComponent<NavMeshAgent>();
        zona1 = GameObject.Find("zona1");
    }

    private void OnTriggerStay(Collider other) {
        if (other.gameObject.name == "Jardim1") {
            JardimState = 1;
        } 
    }

    private void OnTriggerExit(Collider other) {
        if(other.gameObject.name == "Jardim1") {
            JardimState = 2;
        }
    }

    private void FixedUpdate() {

        switch(JardimState) {
            case 1:
                GoToZone();
                break;
            case 2:
                break;
            default:
                break;
        }
    }

    public void GoToZone() {
    
    }


}
