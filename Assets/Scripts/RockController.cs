﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockController : MonoBehaviour
{

    public string RockName = "Dwane The Human Johnson";
    public float hunger = 100f;
    public float friendship = 100f;
    public bool isSick = false;

    float hungerScale = 2f;
    float friendScale = 2f;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(RockName);
    }

    // Update is called once per frame
    void Update()
    {
        StatusUpdate();    
    }

    void StatusUpdate()
    {
        hunger -= Time.deltaTime * hungerScale;
        friendship -= Time.deltaTime * friendScale;

        int sickChance = Random.Range(0, 1000);
        if (sickChance == 1)
        {
            isSick = true;
        }
    }
}
