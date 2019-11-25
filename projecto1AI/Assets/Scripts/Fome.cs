using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fome : MonoBehaviour
{
   /* public float start = 2.0f;
    public float frequency = 5f;
    public bool isInvoke = false;*/
    public Pathfinder agenteinstance;

    private void Start() {
        /* if(isInvoke == true) {
             Invoke();
             isInvoke = false;
         }*/
        agenteinstance = GameObject.FindWithTag("Agent").GetComponent<Pathfinder>();
    }

    public void FixedUpdate() {
       /* if (isInvoke == true) {
           Invoke();
        }
        if(isInvoke == false) {
            CancelInvoke();
        }*/

        /*switch(agenteinstance.State) {
            case 1:
                Debug.Log("Case1");
                break;
            case 2:
                Debug.Log("Case2");
                break;
            default:
                Debug.Log("Default");
                break;
        }*/

    }

    /*public void FomeFunction() {
        Debug.Log("Fome");
        //agenteinstance.Restaurante();
        //agenteinstance.State = 1;
        isInvoke = false;
    }*/

    /*public void Invoke() {
        InvokeRepeating("FomeFunction", start, frequency);
    }*/

    private void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.name == "goal1") {
            Debug.Log("Vais comer");
            //agenteinstance.Concerto();
            agenteinstance.State = 0;
        }
    }

}
