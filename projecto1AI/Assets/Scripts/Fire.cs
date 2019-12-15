using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public int Kill;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Agent")
        {
            Kill++;
            Destroy(other.gameObject);
        }
    }
}
