using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public Transform agenteprefab;

    void Start()
    {
        for(int i = 0; i < 100; i++) {
            Instantiate(agenteprefab, new Vector3(0f, 6f, 26.6f), Quaternion.identity);
        }
    }

    void Update()
    {
        
    }
}
