﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurnAgents : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Agent") {
            Destroy(GameObject.FindWithTag("Agent"));
            //Debug.Log("Queimou agente");
        }
    }
}