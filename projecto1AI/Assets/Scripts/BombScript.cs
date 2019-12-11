using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombScript : MonoBehaviour
{
    public StateMachineMain STMinstance;
    public GameObject Bomb;

    private void Start() {
        STMinstance = GameObject.FindWithTag("Agent").GetComponent<StateMachineMain>();
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            print("Click explosão");
            //Instantiate(Bomb, new Vector3(0f, 2.5f, 0f), Quaternion.identity);
            STMinstance.State = 3;
        }
    }
}
