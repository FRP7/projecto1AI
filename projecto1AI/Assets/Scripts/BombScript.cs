﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombScript : MonoBehaviour
{
    public GameObject Bomb;
    
    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space))
            Bomb.SetActive(true);
    }
}