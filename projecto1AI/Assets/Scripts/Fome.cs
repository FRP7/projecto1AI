using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fome : MonoBehaviour
{
    public float start = 2.0f;
    public float frequency = 5f;

    public bool isInvoke = false;

    private void Start() {
       /* if(isInvoke == true) {
            Invoke();
            isInvoke = false;
        }*/
    }

    public void FixedUpdate() {
        if (isInvoke == true) {
           Invoke();
        }
        if(isInvoke == false) {
            CancelInvoke();
        }
    }

    public void FomeFunction() {
        Debug.Log("Fome");
        isInvoke = false;
    }

    public void Invoke() {
        InvokeRepeating("FomeFunction", start, frequency);
        //isInvoke = false;
    }

}
