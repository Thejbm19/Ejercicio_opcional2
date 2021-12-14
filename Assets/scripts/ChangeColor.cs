using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Color colorRandom;
    public Camera CamaraPrinc;
    

    // Update is called once per frame
    void Update()
    {
        GetComponent<MeshRenderer>().material.color = colorRandom;  //accede al color del prefab
       
    }

    private void OnMouseDown()
    {
        
        CamaraPrinc.GetComponent<Camera>().backgroundColor = colorRandom; // accede al color del background

    }
}
