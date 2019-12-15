using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    public int Escape = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Agent")
        {
            Escape++;
            Destroy(other.gameObject);
        }
    }
}
