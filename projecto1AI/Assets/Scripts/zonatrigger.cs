using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class zonatrigger : MonoBehaviour
{
    public bool zona1;
    public bool zona2;
    public bool zona3;
    public bool zona4;
    public bool zona5;
    public bool zona6;
    public bool zona7;
    public bool zona8;
    public bool zona9;
    public bool zona10;
    public bool zona11;
    public bool zona12;
    public bool zona13;
    public bool zona14;
    public bool zona15;
    public bool zona16;
    //public JardimBehaviour JardimBehaviourinstance;
    public NavMeshAgent NavAgent;

    public void Awake() {
        //JardimBehaviourinstance = GameObject.FindWithTag("Agent").GetComponent<JardimBehaviour>();
        NavAgent = GameObject.FindWithTag("Agent").GetComponent<NavMeshAgent>();
    }

    private void OnTriggerEnter(Collider collision) {
        if(collision.gameObject.tag == "Agent" && zona1 == true) {
            //JardimBehaviourinstance.agentnumber[0] += 1;
            //JardimBehaviourinstance.zona1num += 1;
            NavAgent.ResetPath();
        }
        if (collision.gameObject.tag == "Agent" && zona2 == true) {
            //JardimBehaviourinstance.agentnumber[1] += 1;
            //JardimBehaviourinstance.zona2num += 1;
            NavAgent.ResetPath();
        }
        if (collision.gameObject.tag == "Agent" && zona3 == true) {
            NavAgent.ResetPath();
        }
        if (collision.gameObject.tag == "Agent" && zona4 == true) {
            NavAgent.ResetPath();
        }
        if (collision.gameObject.tag == "Agent" && zona5 == true) {
            NavAgent.ResetPath();
        }
        if (collision.gameObject.tag == "Agent" && zona6 == true) {
            NavAgent.ResetPath();
        }
        if (collision.gameObject.tag == "Agent" && zona7 == true) {
            NavAgent.ResetPath();
        }
        if (collision.gameObject.tag == "Agent" && zona8 == true) {
            NavAgent.ResetPath();
        }
        if (collision.gameObject.tag == "Agent" && zona9 == true) {
            NavAgent.ResetPath();
        }
        if (collision.gameObject.tag == "Agent" && zona10 == true) {
            NavAgent.ResetPath();
        }
        if (collision.gameObject.tag == "Agent" && zona11 == true) {
            NavAgent.ResetPath();
        }
        if (collision.gameObject.tag == "Agent" && zona12 == true) {
            NavAgent.ResetPath();
        }
        if (collision.gameObject.tag == "Agent" && zona13 == true) {
            NavAgent.ResetPath();
        }
        if (collision.gameObject.tag == "Agent" && zona14 == true) {
            NavAgent.ResetPath();
        }
        if (collision.gameObject.tag == "Agent" && zona15 == true) {
            NavAgent.ResetPath();
        }
        if (collision.gameObject.tag == "Agent" && zona16 == true) {
            NavAgent.ResetPath();
        }
    }

   /* private void OnTriggerExit(Collider leave) {
        if(leave.gameObject.tag == "Agent" && zona1 == true) {
            //JardimBehaviourinstance.agentnumber[0] -= 1;
            //JardimBehaviourinstance.zona1num -= 1;
        }
        if (leave.gameObject.tag == "Agent" && zona2 == true) {
            //JardimBehaviourinstance.agentnumber[1] -= 1;
            //JardimBehaviourinstance.zona2num -= 1;
        }
    }*/
}
