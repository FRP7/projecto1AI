using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agente : MonoBehaviour
{
    public Material Verde;
    public Material Azul;
    public GameObject UIName;
    public GameObject UIHunger;
    public GameObject UIEnergy;

    public int HungerLevel;
    public int RestLevel;
    public string[] NomePrimeiro;
    public string[] NomeSegundo;

    private void OnMouseDown()
    {
        UIName.GetComponent<TextMesh>().text = gameObject.name;
        HungerLevel = (int)gameObject.GetComponent<Fome>().HungerLevel;
        UIHunger.GetComponent<TextMesh>().text = $"Fome :    {HungerLevel.ToString()}";
        RestLevel = (int)gameObject.GetComponent<Descansar>().RestLevel;
        UIEnergy.GetComponent<TextMesh>().text = $"Energia : {RestLevel.ToString()}";
        gameObject.GetComponent<Renderer>().material = Verde;
    }

    private void OnMouseUp()
    {
        gameObject.GetComponent<Renderer>().material = Azul;
    }
}
