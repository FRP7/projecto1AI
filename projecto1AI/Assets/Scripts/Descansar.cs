using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Descansar : MonoBehaviour
{
    public StateMachineMain agenteinstance;
    public float RestLevel = 15f;
    public bool Resting = false;

    private void Start() {
        agenteinstance = GameObject.FindWithTag("Agent").GetComponent<StateMachineMain>();
        RestLevel = Random.Range(30f, 50f);
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
            Debug.Log("Resting...");
            RestLevel += (Random.Range(5f, 10f) * Time.fixedDeltaTime);
        }
        else if (RestLevel >= 100f)
        {
            RestLevel = 100f;
            Resting = false;
            agenteinstance.State = 0;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "goal2")
        {
            Resting = true;
        }
        if (other.gameObject.name == "goal22")
        {
            Resting = true;
        }
    }
}
