using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;


public class ColorCh : MonoBehaviour
{
    private Renderer rend;

   
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();    
    }

    // Update is called once per frame
    void Update()
    {
        rend.material.GetFloat("fill");
    }
}
