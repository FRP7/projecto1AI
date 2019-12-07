using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class JardimBehaviour : MonoBehaviour
{
    public int JardimState;
    public NavMeshAgent NavAgent;
    // public int[] agentnumber;
    /*public int zona1num;
    public int zona2num;*/
    public GameObject zona1;
    public GameObject zona2;
    public GameObject zona3;
    public GameObject zona4;
    public GameObject zona5;
    public GameObject zona6;
    public GameObject zona7;
    public GameObject zona8;
    public GameObject zona9;
    public GameObject zona10;
    public GameObject zona11;
    public GameObject zona12;
    public GameObject zona13;
    public GameObject zona14;
    public GameObject zona15;
    public GameObject zona16;

    public int jardim;

    public void Start() {
        NavAgent = GetComponent<NavMeshAgent>();
        zona1 = GameObject.Find("zona1");
        zona2 = GameObject.Find("zona2");
        zona3 = GameObject.Find("zona3");
        zona4 = GameObject.Find("zona4");
        zona5 = GameObject.Find("zona5");
        zona6 = GameObject.Find("zona6");
        zona7 = GameObject.Find("zona7");
        zona8 = GameObject.Find("zona8");
        zona9 = GameObject.Find("zona9");
        zona10 = GameObject.Find("zona10");
        zona11 = GameObject.Find("zona11");
        zona12 = GameObject.Find("zona12");
        zona13 = GameObject.Find("zona13");
        zona14 = GameObject.Find("zona14");
        zona15 = GameObject.Find("zona15");
        zona16 = GameObject.Find("zona16");

        jardim = Random.Range(0, 16);
    }


    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.name == "Jardim1") {
            NavAgent.ResetPath();
            JardimState = 1;
        }
    }

    private void FixedUpdate() {

        switch(JardimState) {
            case 1:
                GoToZone();
                break;
            case 2:
                break;
            default:
                ///não metas nada aqui
                break;
        }
    }

    public void GoToZone() {
        //NavAgent.destination = zona1.transform.position;
        if (jardim == 0) {
            NavAgent.destination = zona1.transform.position;
        }
        if (jardim == 1) {
            NavAgent.destination = zona2.transform.position;
        }
        if (jardim == 2) {
            NavAgent.destination = zona3.transform.position;
        }
        if (jardim == 3) {
            NavAgent.destination = zona4.transform.position;
        }
        if (jardim == 4) {
            NavAgent.destination = zona5.transform.position;
        }
        if (jardim == 5) {
            NavAgent.destination = zona6.transform.position;
        }
        if (jardim == 6) {
            NavAgent.destination = zona7.transform.position;
        }
        if (jardim == 7) {
            NavAgent.destination = zona8.transform.position;
        }
        if (jardim == 8) {
            NavAgent.destination = zona9.transform.position;
        }
        if (jardim == 9) {
            NavAgent.destination = zona10.transform.position;
        }
        if (jardim == 10) {
            NavAgent.destination = zona11.transform.position;
        }
        if (jardim == 11) {
            NavAgent.destination = zona12.transform.position;
        }
        if (jardim == 12) {
            NavAgent.destination = zona13.transform.position;
        }
        if (jardim == 13) {
            NavAgent.destination = zona14.transform.position;
        }
        if (jardim == 14) {
            NavAgent.destination = zona15.transform.position;
        }
        if (jardim == 15) {
            NavAgent.destination = zona16.transform.position;
        }
        return;

    }

}
