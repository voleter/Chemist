using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CantrolMatrial : MonoBehaviour
{
    //Material mat;
    public string matName;

    public float matValeu ;
    public ParticleSystem par;

    void Start()
    {
       
    }

   
    void Update()
    {

        //mat.SetFloat(matName, matValeu);
        

        if (Vector3.Angle(Vector3.down, transform.forward) < 30)
        {

            matValeu -= 0.0009f;
        }
      

    }
}
