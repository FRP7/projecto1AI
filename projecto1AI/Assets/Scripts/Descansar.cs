using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Descansar : MonoBehaviour
{
    public StateMachineMain agenteinstance;
    public float RestLevel = 15f;
    public bool Resting = false;
    public JardimBehaviour JBinstance;
    public NavMeshAgent agent;

    private void Start() {
        agenteinstance = gameObject.GetComponent<StateMachineMain>();

        RestLevel = Random.Range(30f, 50f);

        JBinstance = gameObject.GetComponent<JardimBehaviour>();

        agent = gameObject.GetComponent<NavMeshAgent>();
    }

    public void FixedUpdate()
    {
        if (RestLevel > 0f && Resting == false)
        {
            RestLevel -= Time.fixedDeltaTime;
        }

        else if (agenteinstance.State == 0)
        {
            RestLevel = 0f;
            agenteinstance.State = 2;
        }

        if (RestLevel < 100f && Resting)
        {
            //Debug.Log("Resting...");
            RestLevel += (Random.Range(5f, 10f) * Time.fixedDeltaTime);
        }
        else if (RestLevel >= 100f)
        {
            RestLevel = 100f;
            Resting = false;
            JBinstance.JardimState = 0;
            agenteinstance.State = 0;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Jardim1")
        {
            Resting = true;
            agent.isStopped = true;
            agent.ResetPath();
            JBinstance.JardimState = 1;
        }
    }
}
