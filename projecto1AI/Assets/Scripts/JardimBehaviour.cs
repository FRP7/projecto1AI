using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class JardimBehaviour : MonoBehaviour
{
    public int JardimState = 2;

    public void Start() {

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

    }


}
