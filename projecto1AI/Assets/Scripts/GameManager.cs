using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform agenteprefab;
    public Transform[] agente;
    public Agente AgenteP;

    public string Name = "Default Name";

    void Awake()
    {
        for (int i = 0; i < agente.Length; i++)
        {
            agente[i] = Instantiate(agenteprefab, new Vector3(Random.Range(-19f, 19f), 1.4f, Random.Range(-2f, 55f)), Quaternion.identity);
            Name = $"{AgenteP.NomePrimeiro[(int)Random.Range(0f, AgenteP.NomePrimeiro.Length)]} {AgenteP.NomeSegundo[(int)Random.Range(0f, AgenteP.NomeSegundo.Length)]}";
            agente[i].name = Name;
        }
    }
}
