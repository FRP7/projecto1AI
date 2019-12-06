using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FomeBehaviour : MonoBehaviour
{
    public int FomeState;
    public NavMeshAgent agent;
    public Mesa[] Mesa;
    public Cadeira[] Cadeira;
    public Mesa MesaIdeal;
    public Cadeira CadeiraIdeal;
    public bool Going;

    private Fome fome;

    void Start()
    {
        agent = gameObject.GetComponent<NavMeshAgent>();
        fome = gameObject.GetComponent<Fome>();
    }

    private void FixedUpdate()
    {
        switch (FomeState)
        {
            case 1:
                if (Going == false)
                {
                    CheckMesa();
                    CheckCadeira(MesaIdeal);
                    agent.destination = CadeiraIdeal.Objeto.transform.position;
                    Debug.Log(MesaIdeal.Objeto.name + " " + CadeiraIdeal.Objeto.name + " " + CadeiraIdeal.Objeto.transform.position);
                    MesaIdeal.Agents++;
                    CadeiraIdeal.Ocupado = true;
                    Going = true;
                }
                if (agent.destination == CadeiraIdeal.Objeto.transform.position)
                    fome.Eating = true;
                break;
            case 2:
                MesaIdeal.Agents--;
                CadeiraIdeal.Ocupado = false;
                fome.Eating = false;
                break;
            default:
                //não metas nada aqui
                break;
        }
    }

    public Mesa CheckMesa()
    {
        MesaIdeal = Mesa[0];
        for (int i = 1; i < 6; i++)
            if ((MesaIdeal.Agents - Mesa[i].Agents) > 0)
                MesaIdeal = Mesa[i];
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
}

[System.Serializable]
public class Mesa
{
    public GameObject Objeto;
    public Cadeira[] Cadeira;
    public int Agents = 0;
}

[System.Serializable]
public class Cadeira
{
    public GameObject Objeto;
    public bool Ocupado = false;
}