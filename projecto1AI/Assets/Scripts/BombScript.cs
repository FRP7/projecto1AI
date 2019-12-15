using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombScript : MonoBehaviour
{
    public GameObject Bomb;
    
    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Bomb.SetActive(true);
            foreach (GameObject STMinstance in GameObject.FindGameObjectsWithTag("Agent")) {
                STMinstance.GetComponent<StateMachineMain>().State = 3;
            }
        }
    }
}

////https://stackoverflow.com/questions/14517733/accessing-a-script-on-all-objects-with-tag-in-unity