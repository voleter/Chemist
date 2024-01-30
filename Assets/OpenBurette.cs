using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OpenBurette : MonoBehaviour
{
  public  ParticleSystem _particleSystem;
 public Material _material;
 public GameObject _gameObject;
  public  float materialVal;
  public  SpillFlask _spillFlask;

    void Start()
    {
        _material =_gameObject.GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        _material.SetFloat("_fiil", materialVal);
      
        if (transform.rotation.x >=0.50f)
        {
           
            _particleSystem.gameObject.SetActive(true);

            materialVal +=0.009f *0.001f;
            _spillFlask.mattValeu -= 0.09f *0.01f;
        }
        else
        {
            _particleSystem.gameObject.SetActive(false);


        }

        if (materialVal >= 0.03907899f)
        {
            _material.SetColor("_fresnel_collor", Color.blue);

        }
    }
   

}
