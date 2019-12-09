using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Fome : MonoBehaviour
{
    public StateMachineMain agenteinstance;

    public float HungerLevel = 15f;
    public bool Eating = false;
    public NavMeshAgent agent;
    public FomeBehaviour FBinstance;

    private void Start() {
        agent = GetComponent<NavMeshAgent>();
        agenteinstance = GetComponent<StateMachineMain>();
        FBinstance = GetComponent<FomeBehaviour>();
        HungerLevel = Random.Range(10f, 100f);
    }

    public void FixedUpdate()
    {
        if (HungerLevel > 0f && Eating == false)
        {
            HungerLevel -= Time.fixedDeltaTime;
        }

        else if (agenteinstance.State == 0)
        {
            HungerLevel = 0f;
            agenteinstance.State = 1;
        }

        if (HungerLevel < 100f && Eating)
        {
            //Debug.Log("Eating...");
            HungerLevel += (Random.Range(5f, 20f) * Time.fixedDeltaTime);
        }
        else if (HungerLevel >= 100f)
        {
            HungerLevel = 100f;
            Eating = false;
            FBinstance.MesaIdeal.Agents--;
            FBinstance.CadeiraIdeal.Ocupado = false;
            FBinstance.Going = false;
            FBinstance.FomeState = 0;
            agenteinstance.State = 0;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Restaurante1" && HungerLevel == 0)
        {
            agent.isStopped = true;
            agent.ResetPath();
            FBinstance.FomeState = 1;  //aqui é onde chamas um state qualquer do fome behaviour
        }
    }
}
