using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ExplosionBehaviour : MonoBehaviour
{
    public StateMachineMain agenteinstance;

    public void Start()
    {
        agenteinstance = gameObject.GetComponent<StateMachineMain>();
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            agenteinstance.State = 3;
    }
}
