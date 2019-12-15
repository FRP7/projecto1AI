using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Descansar : MonoBehaviour
{
    public NavMeshAgent agent;
    public StateMachineMain agenteinstance;
    public JardimBehaviour JBinstance;
    public float RestLevel = 15f;
    public bool Resting = false;

    private void Start()
    {
        agent = gameObject.GetComponent<NavMeshAgent>();
        agenteinstance = gameObject.GetComponent<StateMachineMain>();
        JBinstance = gameObject.GetComponent<JardimBehaviour>();
        RestLevel = Random.Range(50f, 100f);
    }

    public void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            JBinstance.JardimState = 0;
            agenteinstance.State = 3;
        }

        if (agenteinstance.State != 3)
        {
            if (RestLevel > 0f && Resting == false)
                RestLevel -= Time.fixedDeltaTime;

            else if (agenteinstance.State == 0)
            {
                RestLevel = 0f;
                agenteinstance.State = 2;
            }

            if (RestLevel < 100f && Resting)
                RestLevel += (Random.Range(10f, 15f) * Time.fixedDeltaTime);

            else if (RestLevel >= 100f)
            {
                RestLevel = 100f;
                Resting = false;
                JBinstance.ZonaIdeal.Agentes--;
                JBinstance.Going = false;
                JBinstance.JardimState = 0;
                agenteinstance.State = 0;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Jardim1" && RestLevel == 0)
        {
            agent.isStopped = true;
            agent.ResetPath();
            JBinstance.JardimState = 1;
        }
    }
}
