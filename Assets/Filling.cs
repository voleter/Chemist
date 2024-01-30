using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Filling : MonoBehaviour
{
    public Material rend;
    public GameObject rendPrefab;
    public  float mattValeu ;


    void Start()
    {
        rend = rendPrefab.GetComponent<Renderer>().material;
    }
    private void Update()
    {
     
        rend.SetFloat("_Filling", mattValeu);


        if (Vector3.Angle(Vector3.down, transform.forward) < 40)
        {

            mattValeu -= 0.0009f;
        }

    

     
    }

}
