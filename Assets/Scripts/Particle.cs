using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour
{
    [SerializeField, Range(1, 0)] private float currentIntensty = 1;
    private float startIntensty;
     public ParticleSystem particle;
    void Start()
    {
        startIntensty = particle.emission.rateOverTime.constant;
    }

    // Update is called once per frame
    void Update()
    {
        //ChangeIntensity();
    }

   //public void ChangeIntensity()
   // {
   //     var emision = particle.emission;
   //     emision.rateOverTime = currentIntensty * startIntensty;

       
   // }

    //public void Spill()
    //{
    //   // amount = currentIntensty;
    //    currentIntensty -= startIntensty;
    //    ChangeIntensity();
    //    StartCoroutine(Timer);

        
    //}
    

}
