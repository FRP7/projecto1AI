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
    public GameObject UIDead;
    public GameObject UIEscape;
    public Exit EscapeExit;
    public Explosion ExplosionDead;
    public Fire FireDead;

    public int HungerLevel;
    public int RestLevel;
    public int Killed = 0;
    public int Escape = 0;
    public string[] NomePrimeiro;
    public string[] NomeSegundo;

    public void Update()
    {
        Killed = ExplosionDead.Kill + FireDead.Kill;
        Escape = EscapeExit.Escape;
        UIDead.GetComponent<TextMesh>().text = $"Killed :    {Killed.ToString()}";
        UIEscape.GetComponent<TextMesh>().text = $"Escaped : {Escape.ToString()}";
    }

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
