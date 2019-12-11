using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombScript : MonoBehaviour
{
    public GameObject STMinstance;
    public GameObject Bomb;

    private void Start() {
        //STMinstance = GameObject.FindWithTag("Agent").GetComponent<StateMachineMain>();
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            print("Click explosão");
            //Instantiate(Bomb, new Vector3(0f, 2.5f, 0f), Quaternion.identity);
            //STMinstance.State = 3;
            foreach (GameObject STMinstance in GameObject.FindGameObjectsWithTag("Agent")) {
                STMinstance.GetComponent<StateMachineMain>().State = 3;
            }
        }
    }
}

////https://stackoverflow.com/questions/14517733/accessing-a-script-on-all-objects-with-tag-in-unity