using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class zonatrigger : MonoBehaviour
{
    public bool zona1;
    public bool zona2;
    public JardimBehaviour JardimBehaviourinstance;
    public NavMeshAgent NavAgent;

    public void Awake() {
        JardimBehaviourinstance = GameObject.FindWithTag("Agent").GetComponent<JardimBehaviour>();
        NavAgent = GameObject.FindWithTag("Agent").GetComponent<NavMeshAgent>();
    }

    private void OnTriggerEnter(Collider collision) {
        if(collision.gameObject.tag == "Agent" && zona1 == true) {
            JardimBehaviourinstance.agentnumber[0] += 1;
            NavAgent.ResetPath();
        }
        if (collision.gameObject.tag == "Agent" && zona2 == true) {
            JardimBehaviourinstance.agentnumber[1] += 1;
            NavAgent.ResetPath();
        }
    }

    private void OnTriggerExit(Collider leave) {
        if(leave.gameObject.tag == "Agent" && zona1 == true) {
            JardimBehaviourinstance.agentnumber[0] -= 1;
        }
        if (leave.gameObject.tag == "Agent" && zona2 == true) {
            JardimBehaviourinstance.agentnumber[1] -= 1;
        }
    }
}
