using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej1 : MonoBehaviour
{
    public int Numero1;
    public int Numero2;

    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("Escriba ds numeros para ver si son iguales");

        if(Numero1 == Numero2)
        {
            Debug.Log("Son el mismo numero");
        }
        else
        {
            Debug.Log("Son numeros diferentes");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
