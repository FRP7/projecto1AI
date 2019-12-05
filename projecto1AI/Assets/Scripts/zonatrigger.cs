using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zonatrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision) {
        if(collision.gameObject.tag == "Agent") {
            Debug.Log("Entrou");
        }
    }

    private void OnTriggerExit(Collider leave) {
        if(leave.gameObject.tag == "Agent") {
            Debug.Log("Saiu");
        }
    }
}
