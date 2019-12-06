using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FomeBehaviour : MonoBehaviour
{
    public int FomeState;

    private void FixedUpdate() {
        switch(FomeState) {
            case 1:
                //Debug.Log("Fome behaviour");
                break;
            case 2:
                break;
            default:
                //não metas nada aqui
                break;
        }
    }
}
