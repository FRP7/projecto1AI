using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agente : MonoBehaviour
{
    public Agente agente;
    public Fome fome;
    public Descansar descansar;
    public GameObject UIName;
    public GameObject UIHunger;
    public GameObject UIEnergy;

    public string[] NomePrimeiro;
    public string[] NomeSegundo;
    public int HungerLevel;
    public int RestLevel;


    private void OnMouseDown()
    {
        UIName.GetComponent<TextMesh>().text = agente.name;
        HungerLevel = (int)fome.HungerLevel;
        UIHunger.GetComponent<TextMesh>().text = $"Fome :    {HungerLevel.ToString()}";
        RestLevel = (int)descansar.RestLevel;
        UIEnergy.GetComponent<TextMesh>().text = $"Energia : {RestLevel.ToString()}";
    }
}
