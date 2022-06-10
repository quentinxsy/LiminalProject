﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]
public class Delay : MonoBehaviour
{
    public GameObject blackhole;
    public GameObject lightTrial;
    public ParticleSystem core;
    
    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine("spawn");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator spawn()
    {
        yield return new WaitForSeconds(30f);
        blackhole.SetActive(true);
        lightTrial.SetActive(true);
        core = GetComponent<ParticleSystem>();
        var corespeed = core.main;
        corespeed.simulationSpeed = 0;


    }
}
