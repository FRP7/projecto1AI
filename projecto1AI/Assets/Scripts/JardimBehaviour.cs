using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class JardimBehaviour : MonoBehaviour
{
    public NavMeshAgent agent;
    public Descansar descansar;
    public ZonaJardim[] Zona;
    public ZonaJardim ZonaIdeal;
    public int JardimState;
    public bool Going = false;

    public void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        descansar = GetComponent<Descansar>();
    }

    private void FixedUpdate()
    {
        switch (JardimState)
        {
            case 1:
                GoToZone();
                break;
            case 2:
                break;
            default:
                break;
        }
    }

    public void GoToZone()
    {
        if (Going == false)
        {
            CheckZona();
            ZonaIdeal.Agentes++;
            Going = true;
        }
        agent.destination = ZonaIdeal.transform.position;
    }

    public ZonaJardim CheckZona()
    {
        ZonaIdeal = Zona[0];

        for (int i = 1; i < Zona.Length; i++)
            if ((ZonaIdeal.Agentes - Zona[i].Agentes) > 0)
                ZonaIdeal = Zona[i];
        return ZonaIdeal;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == ZonaIdeal.GetComponent<Collider>())
            descansar.Resting = true;
    }
}
