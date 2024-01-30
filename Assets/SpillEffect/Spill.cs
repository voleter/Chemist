using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spill : MonoBehaviour
{
    ParticleSystem _particleSystem;
    public Particle PS;
    bool spilling= true;  


    void Start()
    {
        _particleSystem = GetComponent<ParticleSystem>();
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if ( Vector3.Angle(Vector3.down, transform.forward) <50f&&spilling) 
        
        {
            _particleSystem.Play();
         //   StartCoroutine(Timer());



        }
        else
        {
            _particleSystem.Stop();

        }
        

       
    }


    //IEnumerator Timer()

    //{

    //    yield return new WaitForSeconds(3);
    //    spilling = false;

    //    _particleSystem.Stop();


    //}
}
