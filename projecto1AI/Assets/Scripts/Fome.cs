using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fome : MonoBehaviour
{
    public StateMachineMain agenteinstance;
    public float HungerLevel = 15f;
    public bool Eating = false;

    private void Start() {
        agenteinstance = gameObject.GetComponent<StateMachineMain>();
        HungerLevel = Random.Range(10f, 30f);
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

        if (HungerLevel < 60f && Eating)
        {
            //Debug.Log("Eating...");
            HungerLevel += (Random.Range(5f, 10f) * Time.fixedDeltaTime);
        }
        else if (HungerLevel >= 60f)
        {
            HungerLevel = 60f;
            Eating = false;
            agenteinstance.State = 0;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "goal1")
        {
            Eating = true;
        }
        if (other.gameObject.name == "goal11")
        {
            Eating = true;
        }
    }
}
