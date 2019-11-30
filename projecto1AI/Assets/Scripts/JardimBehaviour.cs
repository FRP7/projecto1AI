using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JardimBehaviour : MonoBehaviour
{
    public Transform agentes;
    public int JardimState = 2;
    public int maxSpeed;

    public void Start() {
        agentes = GameObject.FindWithTag("Agent").transform;
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
        transform.Translate(linear * Time.deltaTime); 
    }
}
