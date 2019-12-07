using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform agenteprefab;
    public int agentnumber = 100;

    void Awake()
    {
        for(int i = 0; i < agentnumber; i++) {
            Instantiate(agenteprefab, /*new Vector3(0f, 6f, 26.6f)*/ new Vector3(0f, 0f, 0f), Quaternion.identity);
        }
    }

    void Update()
    {
        
    }
}
