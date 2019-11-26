﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Descansar : MonoBehaviour
{
    public StateMachineMain agenteinstance;

    private void Start() {
        agenteinstance = GameObject.FindWithTag("Agent").GetComponent<StateMachineMain>();
    }


    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.name == "goal2") {
            Debug.Log("Vais descansar");
            agenteinstance.State = 0;
        }
    }
}
