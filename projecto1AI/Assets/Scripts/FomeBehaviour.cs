using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FomeBehaviour : MonoBehaviour
{
    public NavMeshAgent agent;
    public Fome fome;
    public Mesa[] Mesa;
    public Mesa MesaIdeal;
    public Cadeira CadeiraIdeal;
    public int FomeState;
    public bool Going = false;
    public bool Full = false;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        fome = GetComponent<Fome>();
    }

    private void FixedUpdate()
    {
        switch (FomeState)
        {
            case 1:
                GoToZone();
                break;
            case 2:
                break;
            default:
                //não metas nada aqui
                break;
        }
    }

    public void GoToZone()
    {
        if (Going == false)
        {
            CheckMesa();
            if (MesaIdeal.Agents >= 6)
                CheckMesa();
            CheckCadeira(MesaIdeal);
            MesaIdeal.Agents++;
            CadeiraIdeal.Ocupado = true;
            Going = true;
        }
        agent.destination = CadeiraIdeal.transform.position;
    }

    public Mesa CheckMesa()
    {
        MesaIdeal = Mesa[0];

        for (int i = 1; i < 6; i++)
        {
            if ((MesaIdeal.Agents - Mesa[i].Agents) > 0 || MesaIdeal.Agents >= 6)
                MesaIdeal = Mesa[i];
        }
        return MesaIdeal;
    }

    public Cadeira CheckCadeira(Mesa MesaIdeal)
    {
        CadeiraIdeal = MesaIdeal.Cadeira[0];

        for (int i = 1; i < 6; i++)
        {
            if (CadeiraIdeal.Ocupado)
                CadeiraIdeal = MesaIdeal.Cadeira[i];
            else
                break;
        }
        return CadeiraIdeal;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other == CadeiraIdeal.GetComponent<Collider>())
        {
            fome.Eating = true;
        }
    }
}